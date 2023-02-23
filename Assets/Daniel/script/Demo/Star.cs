using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public PlayerInfo info;

    // Start is called before the first frame update
    void Start()
    {
        //find gameobject of a specific type in the game scene
        info = GameObject.FindObjectOfType<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            info.star += 1;
            Destroy(this.gameObject);
        }
    }
}
