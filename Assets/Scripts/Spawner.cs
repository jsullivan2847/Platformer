using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float freq;
    float clock = 0;
    public GameObject spawn;

    public Transform player;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        clock += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
       clock += Time.deltaTime;
       Spawn();

    }


    Vector3 SpawnPos(){
        
        float xPos = Random.Range(player.position.x - 10f, player.position.x + 10f);
        float zPos = Random.Range(player.position.z, player.position.z + 20f);
        return new Vector3 (xPos, player.position.y + 10f, zPos);

        
    }

    void Spawn(){
        if(clock >= freq){
            clock = 0f;
            Instantiate(spawn, SpawnPos(), Quaternion.identity);
        }
    }
}
