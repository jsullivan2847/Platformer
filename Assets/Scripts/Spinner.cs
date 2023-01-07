using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAng = 0;
    [SerializeField] float yAng = 0;
    [SerializeField] float zAng = 0;

    bool go;
    float clock;
    [SerializeField] float start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        if(clock >= start){
            transform.Rotate(xAng, yAng, zAng, Space.World);
        }
    }
}
