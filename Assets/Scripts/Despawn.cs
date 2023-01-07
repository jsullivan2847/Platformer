using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float clock;
    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(myCoroutine());
    }


    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator myCoroutine(){
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
