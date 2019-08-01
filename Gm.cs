using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gm : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;

  public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }


  public void gameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("restart", 2f);
        }
    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
