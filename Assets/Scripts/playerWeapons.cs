using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWeapons : MonoBehaviour
{
    Animator animator;
    public KeyCode swordKey = KeyCode.Mouse0;
    public LookAtMouse lookAtMouse;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sword

        if (Input.GetKeyDown(swordKey))
        {
            animator.SetTrigger("SwordAttackTrigger");
            lookAtMouse.canSpinnyness = false;
            StartCoroutine(WaitForCanSpinnyness());
        }
    }

    IEnumerator WaitForCanSpinnyness()
    {
        yield return new WaitForSeconds(1.27f);
        print("BEANS");
        lookAtMouse.canSpinnyness = true;
    }
}
