using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    public void Go(){

        Debug.Log("come on...");
        CanvasGroup visible = GetComponent<CanvasGroup>();
        Mover mover = GameObject.FindGameObjectWithTag("Player").GetComponent<Mover>();
        // Debug.Log(visible.alpha);
        Time.timeScale = 0;
        mover.enabled = false;
        visible.alpha = 1;
    }

    public void PlayAgain(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
