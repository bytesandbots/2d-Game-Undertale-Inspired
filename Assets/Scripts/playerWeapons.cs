using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWeapons : MonoBehaviour
{
    public KeyCode punchKey = KeyCode.Mouse0;
    public punchAnimation punchAnimation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Leash

        if (Input.GetKeyDown(punchKey))
        {
            punchAnimation.animator.SetBool("isPunching", true);
        }

        if (Input.GetKeyUp(punchKey))
        {
            punchAnimation.animator.SetBool("isPunching", false);
        }
    }
}
