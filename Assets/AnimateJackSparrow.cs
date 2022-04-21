using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateJackSparrow : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WalkForwardStart");
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetTrigger("WalkForwardStop");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("WalkBackwardStart");
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetTrigger("WalkBackwardStop");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
    }
}
