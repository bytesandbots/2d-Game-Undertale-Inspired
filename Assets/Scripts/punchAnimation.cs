using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchAnimation : MonoBehaviour
{
    public Animator animator;
    public void Punching()
    {
        animator.SetBool("isPunching", true);
    }
}
