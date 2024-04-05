using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Photon.Pun;
using Photon.Realtime;
public class numberofpeople : MonoBehaviour
{

    public TMP_Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Players "+ PhotonNetwork.CurrentRoom.PlayerCount;
           
    }
}
