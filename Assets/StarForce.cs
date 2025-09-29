using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarForce : MonoBehaviour
{
    public Vector3 StartForce;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(StartForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
