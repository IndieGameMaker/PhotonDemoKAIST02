using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Cinemachine;
//Text Mesh Pro의 네임스페이스
using TMPro;  

// bf33a4aa-4e6d-46a5-b04b-c1c6353b5fda
// C:\Users\accountName\AppData\Roaming\Unity\Asset Store\
public class TankCtrl : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float turnSpeed = 100.0f;
    public TMP_Text nickNameText;

    private Transform tr;
    private PhotonView pv;
    private CinemachineVirtualCamera cv;

    void Start()
    {
        tr = GetComponent<Transform>(); 
        pv = GetComponent<PhotonView>(); 
        // cv = GameObject.FindGameObjectWithTag("V_CAM").GetComponent<CinemachineVirtualCamera>();

        // if (pv.IsMine)
        // {
        //     cv.Follow = this.gameObject.transform;  //this.transform // transform // gameObject.transform
        //     cv.LookAt = this.gameObject.transform;  //this.gameObejct.GetComponent<Transform>()
        // }
        nickNameText.text = pv.Owner.NickName;
    }

    void Update()
    {
        if (pv.IsMine == false) return;

        float v = Input.GetAxis("Vertical");   // Up, Down Arrow , W, S [-1.0f ~ 0.0f ~ 1.0f]
        float h = Input.GetAxis("Horizontal"); // Left, Right Arrow, A, D [-1.0f ~ 0.0f ~ 1.0f]

        tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed * 0.03f * v);
        tr.Rotate(Vector3.up * Time.deltaTime * turnSpeed * h);        
    }
}
