using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   
    public void Go(){

        Debug.Log("come on...");
        CanvasGroup visible = GameObject.FindGameObjectWithTag("Game Over").GetComponent<CanvasGroup>();
        Mover mover = GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>();
        Time.timeScale = 0;
        // Debug.Log(visible.alpha);
        mover.enabled = false;
        visible.alpha = 1;
    }

    public void PlayAgain(){
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
