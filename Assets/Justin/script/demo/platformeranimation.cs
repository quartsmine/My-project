using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformeranimation : MonoBehaviour
{
    Animator animator;
    public float speed = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSpeed();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("jump", true);
        }
    }
    void UpdateSpeed()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetFloat("Blend", 0f);
            }
            else
            {
                animator.SetFloat("Blend", speed);
            }
        }
        else
        {
            animator.SetFloat("Blend", 0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        animator.SetBool("jump", false);
    }

}
