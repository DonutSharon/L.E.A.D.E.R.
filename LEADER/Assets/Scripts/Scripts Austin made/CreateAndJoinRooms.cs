using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using static isInstructor;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public void Start()
    {
        
        isInstructor.Instructor = false;
        PhotonNetwork.JoinRoom("ROOM 1");
        PhotonNetwork.LoadLevel("L.E.A.D.E.R");



    }


   

}
