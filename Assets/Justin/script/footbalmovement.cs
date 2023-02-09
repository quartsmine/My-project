using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footbalmovement : MonoBehaviour
{
    public Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.RightShift))
            {
                float s = Mathf.Lerp(animator.GetFloat("ForwardSpeed"), 1.1f, 0.01f);
                animator.SetFloat("ForwardSpeed", s);
            }
            else 
            {
                float s = Mathf.Lerp(animator.GetFloat("ForwardSpeed"), 0.5f, 0.01f);
                animator.SetFloat("ForwardSpeed", s);
            }
        }

        if (!Input.GetKey(KeyCode.UpArrow))
        {
            float s = Mathf.Lerp(animator.GetFloat("ForwardSpeed"), 0, 0.01f);
            animator.SetFloat("ForwardSpeed", s);
        }



        //rightSpeed dont get updated
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float s = Mathf.Lerp(animator.GetFloat("RightSpeed"), -1f, 0.01f);
            animator.SetFloat("RightSpeed", s);
        }
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float s = Mathf.Lerp(animator.GetFloat("RightSpeed"), 1f, 0.01f);
            animator.SetFloat("RightSpeed", s);
        }

        /*
        if (!Input.GetKey(KeyCode.LeftArrow) || !Input.GetKey(KeyCode.RightArrow))
        {
            float s = Mathf.Lerp(animator.GetFloat("RightSpeed"), 0, 0.01f);
            animator.SetFloat("RightSpeed", s);
        }
        */
        
        // Debug.Log(animator.GetFloat("ForwardSpeed"));
        Debug.Log(animator.GetFloat("RightSpeed"));
    }
}
