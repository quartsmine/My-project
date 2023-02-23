using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerInfo info;
    // Start is called before the first frame update
    void Start()
    {
        info = GameObject.FindObjectOfType<PlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            info.health -= 1;
        }
    }
}
