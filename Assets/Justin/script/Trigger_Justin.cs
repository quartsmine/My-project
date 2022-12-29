using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Justin : MonoBehaviour
{
    public GameObject doorHinge;
    public GameObject player;
    public Vector3 openDoorDegrees;
    public int flagofentering;
    bool open = false;
    public Animator dooranim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        dooranim.SetTrigger("isdoortriger");

    }
    /*
    private void OnTriggerExit(Collider player)
    {
        Debug.Log("untriggered");
        if (flagofentering==1)
        {
            closeDoor();
            flagofentering = 0;
        }

        open = false;
        

    }

    public void OpenDoor()
    {
        if (doorHinge.GetComponent<Transform>().rotation.eulerAngles.y < 180f) 
        {
            if (open) 
            {
                doorHinge.GetComponent<Transform>().Rotate(openDoorDegrees * Time.deltaTime, Space.Self);
            }
            
        }
        
    }
    public void closeDoor()
    {
        doorHinge.GetComponent<Transform>().Rotate(-openDoorDegrees, Space.Self);
    }
    */
}
