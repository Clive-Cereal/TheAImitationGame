using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    private int _occupants = 0;
    private static readonly int IsOpened = Animator.StringToHash("isOpened");

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Subject"))
        {
            _occupants++;
            anim.SetBool(IsOpened, true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Subject"))
        {
            _occupants--;
            if (_occupants <= 0)
            {
                _occupants = 0;
                anim.SetBool(IsOpened, false);
            }
        }
    }
}
