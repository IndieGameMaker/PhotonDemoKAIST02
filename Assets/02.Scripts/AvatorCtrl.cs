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
        if (!PhotonView.IsMine)
        {
            mrtkObj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
