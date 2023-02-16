using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformermovement_Daniel : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float jumpForce = 1f;
    private bool isInAir = false;
    private int facingdirection = 0;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        
        Debug.Log(isInAir);
    }
    void MoveLeft()
    {
        gameObject.transform.Translate(gameObject.transform.forward * moveSpeed * Time.deltaTime, Space.World);
        if (facingdirection != 1)
        {
        gameObject.transform.Rotate(0f, 180, 0f, Space.Self);
        facingdirection = 1;
        }
        
    }

    //move to right
    void MoveRight()
    {
        gameObject.transform.Translate(gameObject.transform.forward * moveSpeed * Time.deltaTime, Space.World);
        if (facingdirection != 0)
        {
            gameObject.transform.Rotate(0f, 180, 0f, Space.Self);
            facingdirection = 0;
        }
    }

    void Jump()
    {
        if (!isInAir)
        {
            GetComponent<Rigidbody>().AddForce(gameObject.transform.up * jumpForce, ForceMode.Force);
            animator.SetTrigger("jump");
            isInAir = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isInAir = false;
    }
}
