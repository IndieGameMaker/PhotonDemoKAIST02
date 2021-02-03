using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float speed = 1000.0f;

    void Start()
    {
        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed); 
    }

}