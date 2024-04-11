using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using static isInstructor;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public void Start()
    {
        PhotonNetwork.JoinRoom("ROOM 1");
        Debug.Log(PhotonNetwork.CurrentRoom != null);
        PhotonNetwork.LoadLevel("L.E.A.D.E.R");



    }


   

}
