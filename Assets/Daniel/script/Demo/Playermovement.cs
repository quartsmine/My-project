using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float jumpForce = 1f;
    private bool isInAir = false;
    // Start is called before the first frame update
    void Start()
    {
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


    //move to left
    void MoveLeft() 
    {
        gameObject.transform.Translate(gameObject.transform.forward * moveSpeed * Time.deltaTime *-1f, Space.World);
    }

    //move to right
    void MoveRight() 
    {
        gameObject.transform.Translate(gameObject.transform.forward * moveSpeed * Time.deltaTime, Space.World);
    }

    void Jump() 
    {
        if (!isInAir) 
        {
            GetComponent<Rigidbody>().AddForce(gameObject.transform.up * jumpForce, ForceMode.Force);
            isInAir = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isInAir = false;
    }
}
