using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public int star = 0;
    public int health = 3;
    public Text healthCount;
    public Text starCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per f
    // rame
    void Update()
    {
        healthCount.text = health.ToString();
        starCount.text = star.ToString();
    }
}
