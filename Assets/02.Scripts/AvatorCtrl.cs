using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AvatorCtrl : MonoBehaviour
{
    private PhotonView pv;

    public GameObject mrtkObj;

    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
        if (!pv.IsMine)
        {
            mrtkObj = GameObject.Find("MixedRealityPlayspace");
            mrtkObj.transform.parent = this.transform;
            mrtkObj.transform.localPosition = Vector3.zero + (Vector3.up * 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
