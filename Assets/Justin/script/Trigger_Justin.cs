using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Justin : MonoBehaviour
{
    public GameObject doorHinge;
    public GameObject player;
    public Vector3 openDoorDegrees;
    public int flagofentering;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider player)
    {
        Debug.Log("triggered");
        OpenDoor();
        flagofentering = 1;

    }

    private void OnTriggerExit(Collider player)
    {
        Debug.Log("untriggered");
        if (flagofentering==1)
        {
            closeDoor();
            flagofentering = 0;
        }
        

    }

    public void OpenDoor()
    {
        doorHinge.GetComponent<Transform>().Rotate(openDoorDegrees, Space.Self);
    }
    public void closeDoor()
    {
        doorHinge.GetComponent<Transform>().Rotate(-openDoorDegrees, Space.Self);
    }
}
