using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool EndGame = false;
    
    void Update()
    {
        if (EndGame == true)
        {
            Application.Quit();
        }
        
    }
    public void GameOver()
    {
        EndGame = true;
    }
}
