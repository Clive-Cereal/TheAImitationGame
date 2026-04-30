using System.IO;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class TopDownMapCapture : MonoBehaviour
{
    [SerializeField] private int imageWidth = 2048;
    [SerializeField] private int imageHeight = 2048;
    [SerializeField] private string fileName = "GeneratedMapCore.png";

    [ContextMenu("Capture Top Down Map")]
    public void Capture()
    {
        Camera cam = GetComponent<Camera>();

        float oldAspect = cam.aspect;
        RenderTexture oldTarget = cam.targetTexture;
        RenderTexture oldActive = RenderTexture.active;

        cam.aspect = (float)imageWidth / imageHeight;

        RenderTexture rt = new RenderTexture(imageWidth, imageHeight, 24);
        cam.targetTexture = rt;

        Texture2D tex = new Texture2D(imageWidth, imageHeight, TextureFormat.RGBA32, false);

        cam.Render();

        RenderTexture.active = rt;
        tex.ReadPixels(new Rect(0, 0, imageWidth, imageHeight), 0, 0);
        tex.Apply();

        byte[] bytes = tex.EncodeToPNG();
        string path = Path.Combine(Application.dataPath, fileName);
        File.WriteAllBytes(path, bytes);

        cam.targetTexture = oldTarget;
        RenderTexture.active = oldActive;
        cam.aspect = oldAspect;

        DestroyImmediate(rt);
        DestroyImmediate(tex);

        Debug.Log("Top down map saved to: " + path);
    }
}