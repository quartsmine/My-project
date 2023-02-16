using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public Transform transform;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Moveforward(moveSpeed);
        Movebackward(moveSpeed); 
        Moveleft(moveSpeed);
        Moveright(moveSpeed);
    }

    void Moveforward(float a)
    {
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 newPosw;
            newPosw = transform.position;
            newPosw.z += a;
            transform.position = newPosw;  
        }
    }
    void Movebackward(float a)
    {
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPoss;
            newPoss = transform.position;
            newPoss.z -= a;
            transform.position = newPoss;
        }
    }

    void Moveleft(float a)
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPosa;
            newPosa = transform.position;
            newPosa.x -= a;
            transform.position = newPosa;
        }
    }
    void Moveright(float a)
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosd;
            newPosd = transform.position;
            newPosd.x += a;
            transform.position = newPosd;
        }
    }




}
