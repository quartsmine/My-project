using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public Animator doorAnimator;
    

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
        if (other.gameObject.CompareTag("Players")) 
        {
            doorAnimator.SetTrigger("openDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }


    public void OpenDoor() 
    {
        
    }


}
