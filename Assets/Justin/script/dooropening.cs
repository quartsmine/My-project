using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropening : MonoBehaviour
{
    public Transform transform;
    public float a;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, a, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        a = 90f;
    }
    /*
    private void OnTriggerExit(Collider other)
    {
        a = 90f;
    }
    */
}
