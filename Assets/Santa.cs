using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour
{
    public Vector3 vect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vect*Time.deltaTime);
    }
}
