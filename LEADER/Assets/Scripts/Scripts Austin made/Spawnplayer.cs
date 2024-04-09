using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;


public class Spawnplayer : MonoBehaviourPunCallbacks
{
    private Vector3 spawnLocation;
    private GameObject playerBody;
    public GameObject playerPrefab;
    public float x;
    public float y;
    public float z;
    
    
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("Other players joined the room.");
        Vector3 position = new Vector3(x, y, z);
        PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);

    }
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(playerBody);
    }

}

