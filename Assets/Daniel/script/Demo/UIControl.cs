using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject startIMG;
    public GameObject endIMG;
    // Start is called before the first frame update
    void Start()
    {
        endIMG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //this func is for start button
    public void GameStart() 
    {
        startIMG.SetActive(false);
    }

    //this func is for restart button
    public void GameRestart() 
    {
        SceneManager.LoadScene("Demo");
    }


    //this funx is for quit the game
    public void ExitGame() 
    {
        Application.Quit();
    }

    public void GameOver() 
    {
        endIMG.SetActive(true);
    }
}
