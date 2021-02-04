using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Tank 생성
        Vector3 pos = new Vector3(Random.Range(-10, 10), 0.0f, Random.Range(-10, 10));
        PhotonNetwork.Instantiate("Tank", pos, Quaternion.identity, 0);        
        //Avator 생성
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
