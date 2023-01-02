using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = Color.red;
    }
}
