using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{

    [SerializeField] float timer;
    Renderer render;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        render = this.GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timer - 1f){
            render.enabled = true;
        }
        
        if(Time.time >= timer){
            rb.useGravity = true;
        }
        // Debug.Log(Time.time);
    }
}
