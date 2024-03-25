using Photon.Pun;
using Photon.Realtime;


public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public byte MaxPlayersPerRoom = 4;
    public void Start()
    {
        PhotonNetwork.CreateRoom("default", new RoomOptions() { MaxPlayers = MaxPlayersPerRoom }, null);

    }


    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("L.E.A.D.E.R");
    }

}
