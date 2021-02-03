#pragma warning disable IDE0044, IDE0051, IDE0052
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    private const string version = "1.0"; //버전별로 접속할 수 있게하는 역할
    private string userName = "Zack";
    private byte maxPlayerCount = 20;

    void Awake()
    {
        //새로운 씬을 호출을 할 경우 자동으로 씬이 호출이 되는 기능
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    void Start()
    {
        PhotonNetwork.NickName = userName;
        PhotonNetwork.GameVersion = version;
        Debug.Log(version);

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected !!!");
        //랜덤 조인
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log($"Join Failed code={returnCode}, msg={message}");

        RoomOptions op = new RoomOptions();
        op.MaxPlayers = maxPlayerCount;
        op.IsOpen = true;
        op.IsVisible = true;

        PhotonNetwork.CreateRoom("My Room", op);
    }

    //콜백 함수 (Call Back Function) , 이벤트 함수(Event Function)
    public override void OnJoinedRoom()
    {
        Debug.Log("Create and Joined Room !!!");
        PhotonNetwork.Instantiate("Tank", Vector3.zero, Quaternion.identity, 0);
    }
}
