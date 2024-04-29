using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeController : MonoBehaviour
{
    public Animator anim;
    public bool opener;
    public bool closer;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Boom") && opener)
        {
            anim.SetBool("summon", true);
        }
        if (closer) {
            anim.SetBool("summon", false);
        }
    }
}
