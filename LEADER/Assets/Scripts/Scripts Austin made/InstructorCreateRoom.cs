using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using static isInstructor;
using UnityEngine;

public class InstructorCreateRoom : MonoBehaviourPunCallbacks
{
    public byte MaxPlayersPerRoom = 4;
    public void Start()
    {
        PhotonNetwork.CreateRoom("ROOM 1");
        Debug.Log("room created, yay!");



    }


    public override void OnJoinedRoom()
    {

        PhotonNetwork.LoadLevel("L.E.A.D.E.R");
    }
}
