using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class FireCtrl : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    private PhotonView pv;

    // Start is called before the first frame update
    void Start()
    {
        pv = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pv.IsMine == false) return;
        
        if (Input.GetMouseButtonDown(0))
        {
           Fire(); 
        }
    }

    void Fire()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
    }
}
