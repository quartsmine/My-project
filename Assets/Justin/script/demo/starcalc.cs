using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starcalc : MonoBehaviour
{
    // Start is called before the first frame update
    public playerstat info;
    void Start()
    {
        info = GameObject.FindObjectOfType<playerstat>();
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
