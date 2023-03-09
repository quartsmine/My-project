using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerstat : MonoBehaviour
{
    // Start is called before the first frame update
    public int star = 0;
    public int health = 3;
    public Text healthCount;
    public Text starCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthCount.text = health.ToString();
        starCount.text = star.ToString();
    }
}
