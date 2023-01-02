using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    [SerializeField] float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timer){
            GetComponent<Rigidbody>().useGravity = false;
        }
        Debug.Log(Time.time);
    }
}
