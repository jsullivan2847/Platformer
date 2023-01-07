using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    public GameObject gameOver;
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Player"){
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.material.color = Color.red;
            if(gameOver.GetComponent<GameOver>()){
                 gameOver.GetComponent<GameOver>().Go();
            }
            else {
                gameOver.GetComponent<GameWin>().Go();
            }
        }
    }
}
