using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawnplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;

    public float x;
    public float y;
    public float z;
    // Update is called once per frame
    private void Start()
    {
        Vector3 position = new Vector3(x, y, z);
        PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
    }
}
