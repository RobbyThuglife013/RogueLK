using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        if (Input.GetKey("a"))
        {
            animator.SetBool("isLeft", true);
        }
        else
        {
            animator.SetBool("isLeft", false);
        }
        if (Input.GetKey("d"))
        {
            animator.SetBool("isRight", true);
        }
        else
        {
            animator.SetBool("isRight", false);
        }
        if (Input.GetKey("s"))
        {
            animator.SetBool("IsBack", true);
        }
        else
        {
            animator.SetBool("IsBack", false);
        }
    
    }
}
