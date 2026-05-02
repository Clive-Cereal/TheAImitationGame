using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MazePuzzleManager : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private GameObject puzzlePanel;
    [SerializeField] private RectTransform gridRoot;
    [SerializeField] private TMP_Text instructionText;
    [SerializeField] private CanvasGroup puzzleCanvasGroup;

    [Header("Maze Settings")]
    [SerializeField, Min(5)] private int mazeWidth = 7;
    [SerializeField, Min(5)] private int mazeHeight = 7;
    [SerializeField] private float heldMoveCooldown = 0.14f;
    [SerializeField] private float cellSpacing = 2f;

    [Header("Cell Colours")]
    [SerializeField] private Color wallColor = new Color(0.08f, 0.08f, 0.08f, 1f);
    [SerializeField] private Color floorColor = new Color(0.75f, 0.75f, 0.75f, 1f);
    [SerializeField] private Color playerColor = new Color(0.1f, 0.45f, 1f, 1f);
    [SerializeField] private Color exitColor = new Color(0.1f, 0.8f, 0.2f, 1f);

    private const int Wall = 1;
    private const int Floor = 0;

    private readonly List<Image> cells = new List<Image>();

    private int[,] maze;
    private Vector2Int playerPos;
    private Vector2Int exitPos;

    private Action onSolved;
    private bool isActive;
    private float nextMoveTime;

    private void Awake()
    {
        EnsureReferences();
        SetPuzzleVisible(false);
    }

    private void Update()
    {
        if (!isActive) return;

        Keyboard keyboard = Keyboard.current;
        if (keyboard == null) return;
        if (Time.unscaledTime < nextMoveTime) return;

        Vector2Int direction = Vector2Int.zero;

        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
            direction = Vector2Int.up;
        else if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
            direction = Vector2Int.down;
        else if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            direction = Vector2Int.left;
        else if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            direction = Vector2Int.right;

        if (direction == Vector2Int.zero) return;

        nextMoveTime = Time.unscaledTime + heldMoveCooldown;
        TryMove(direction);
    }

    public void StartPuzzle(Action solvedCallback)
    {
        EnsureReferences();

        if (puzzlePanel == null || gridRoot == null)
        {
            Debug.LogError(
                "MazePuzzleManager: puzzlePanel or gridRoot is not assigned. " +
                $"puzzlePanel={(puzzlePanel == null ? "NULL" : puzzlePanel.name)}, " +
                $"gridRoot={(gridRoot == null ? "NULL" : gridRoot.name)}"
            );

            solvedCallback?.Invoke();
            return;
        }

        onSolved = solvedCallback;
        isActive = true;
        nextMoveTime = 0f;

        if (UIManager.Instance != null)
        {
            UIManager.Instance.HidePanel();
        }

        SetPuzzleVisible(true);

        mazeWidth = MakeOdd(Mathf.Max(5, mazeWidth));
        mazeHeight = MakeOdd(Mathf.Max(5, mazeHeight));

        GenerateMaze();
        BuildGridIfNeeded();
        RefreshGrid();

        if (instructionText != null)
        {
            instructionText.text = "Security Check: use WASD / Arrow Keys to reach the green exit.";
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ForceClose()
    {
        isActive = false;
        onSolved = null;

        SetPuzzleVisible(false);
    }

    private void CompletePuzzle()
    {
        isActive = false;

        SetPuzzleVisible(false);

        Action callback = onSolved;
        onSolved = null;
        callback?.Invoke();
    }

    private void EnsureReferences()
    {
        if (puzzlePanel == null) return;

        if (!puzzlePanel.activeSelf)
        {
            puzzlePanel.SetActive(true);
        }

        if (puzzleCanvasGroup == null)
        {
            puzzleCanvasGroup = puzzlePanel.GetComponent<CanvasGroup>();
        }

        if (puzzleCanvasGroup == null)
        {
            puzzleCanvasGroup = puzzlePanel.AddComponent<CanvasGroup>();
        }
    }

    private void SetPuzzleVisible(bool visible)
    {
        if (puzzlePanel == null) return;

        if (!puzzlePanel.activeSelf)
        {
            puzzlePanel.SetActive(true);
        }

        if (puzzleCanvasGroup == null)
        {
            puzzleCanvasGroup = puzzlePanel.GetComponent<CanvasGroup>();
        }

        if (puzzleCanvasGroup == null)
        {
            puzzleCanvasGroup = puzzlePanel.AddComponent<CanvasGroup>();
        }

        puzzleCanvasGroup.alpha = visible ? 1f : 0f;
        puzzleCanvasGroup.interactable = visible;
        puzzleCanvasGroup.blocksRaycasts = visible;
    }

    private void TryMove(Vector2Int direction)
    {
        Vector2Int next = playerPos + direction;

        if (!IsInside(next)) return;
        if (maze[next.x, next.y] == Wall) return;

        playerPos = next;
        RefreshGrid();

        if (playerPos == exitPos)
        {
            CompletePuzzle();
        }
    }

    private void GenerateMaze()
    {
        maze = new int[mazeWidth, mazeHeight];

        for (int x = 0; x < mazeWidth; x++)
        {
            for (int y = 0; y < mazeHeight; y++)
            {
                maze[x, y] = Wall;
            }
        }

        playerPos = new Vector2Int(1, 1);
        exitPos = new Vector2Int(mazeWidth - 2, mazeHeight - 2);

        CarveFrom(playerPos);

        maze[playerPos.x, playerPos.y] = Floor;
        maze[exitPos.x, exitPos.y] = Floor;
    }

    private void CarveFrom(Vector2Int current)
    {
        maze[current.x, current.y] = Floor;

        List<Vector2Int> directions = new List<Vector2Int>
        {
            Vector2Int.up,
            Vector2Int.down,
            Vector2Int.left,
            Vector2Int.right
        };

        Shuffle(directions);

        foreach (Vector2Int direction in directions)
        {
            Vector2Int next = current + direction * 2;
            if (!IsCarvable(next)) continue;

            Vector2Int between = current + direction;
            maze[between.x, between.y] = Floor;

            CarveFrom(next);
        }
    }

    private bool IsCarvable(Vector2Int pos)
    {
        if (pos.x <= 0 || pos.x >= mazeWidth - 1) return false;
        if (pos.y <= 0 || pos.y >= mazeHeight - 1) return false;

        return maze[pos.x, pos.y] == Wall;
    }

    private bool IsInside(Vector2Int pos)
    {
        return pos.x >= 0 &&
               pos.x < mazeWidth &&
               pos.y >= 0 &&
               pos.y < mazeHeight;
    }

    private void BuildGridIfNeeded()
    {
        int requiredCount = mazeWidth * mazeHeight;

        GridLayoutGroup layout = gridRoot.GetComponent<GridLayoutGroup>();
        if (layout == null)
        {
            layout = gridRoot.gameObject.AddComponent<GridLayoutGroup>();
        }

        layout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        layout.constraintCount = mazeWidth;
        layout.childAlignment = TextAnchor.MiddleCenter;
        layout.spacing = new Vector2(cellSpacing, cellSpacing);

        float availableWidth = gridRoot.rect.width - cellSpacing * (mazeWidth - 1);
        float availableHeight = gridRoot.rect.height - cellSpacing * (mazeHeight - 1);
        float cellSize = Mathf.Max(8f, Mathf.Min(availableWidth / mazeWidth, availableHeight / mazeHeight));

        layout.cellSize = new Vector2(cellSize, cellSize);

        while (cells.Count < requiredCount)
        {
            GameObject cellObject = new GameObject("MazeCell", typeof(RectTransform), typeof(Image));
            cellObject.transform.SetParent(gridRoot, false);
            cells.Add(cellObject.GetComponent<Image>());
        }

        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].gameObject.SetActive(i < requiredCount);
        }
    }

    private void RefreshGrid()
    {
        if (maze == null) return;

        for (int displayY = 0; displayY < mazeHeight; displayY++)
        {
            int y = mazeHeight - 1 - displayY;

            for (int x = 0; x < mazeWidth; x++)
            {
                int index = displayY * mazeWidth + x;
                Image image = cells[index];
                Vector2Int pos = new Vector2Int(x, y);

                if (pos == playerPos)
                {
                    image.color = playerColor;
                }
                else if (pos == exitPos)
                {
                    image.color = exitColor;
                }
                else
                {
                    image.color = maze[x, y] == Wall ? wallColor : floorColor;
                }
            }
        }
    }

    private int MakeOdd(int value)
    {
        return value % 2 == 0 ? value + 1 : value;
    }

    private void Shuffle<T>(IList<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int randomIndex = UnityEngine.Random.Range(i, list.Count);

            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}