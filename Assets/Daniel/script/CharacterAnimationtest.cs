using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationtest : MonoBehaviour
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
            animator.SetFloat("ForwardSpeed", (float)(animator.GetFloat("ForwardSpeed") + 0.2 * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetFloat("ForwardSpeed", (float)(animator.GetFloat("ForwardSpeed") - 0.2 * Time.deltaTime));
        }

        Debug.Log(animator.GetFloat("ForwardSpeed"));
    }
}
