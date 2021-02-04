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
        Vector3 pos = new Vector3(Random.Range(-10, 10) * 0.03f, 0.0f, Random.Range(-10, 10) * 0.03f);
        PhotonNetwork.Instantiate("Tank", pos, Quaternion.identity, 0);        
        //Avator 생성
        Vector2 pos02 = Random.insideUnitCircle * 3.0f;
        PhotonNetwork.Instantiate("Avator", new Vector3(pos02.x, 1.0f, pos02.y), Quaternion.identity, 0);
    }


}
