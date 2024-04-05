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
        isInstructor.Instructor = true;
        PhotonNetwork.CreateRoom("Room");



    }


    public override void OnJoinedRoom()
    {

        PhotonNetwork.LoadLevel("L.E.A.D.E.R");
    }
}
