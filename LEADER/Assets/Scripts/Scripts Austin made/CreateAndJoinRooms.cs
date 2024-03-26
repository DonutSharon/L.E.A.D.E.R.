using Photon.Pun;
using Photon.Realtime;


public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public byte MaxPlayersPerRoom = 4;
    public void Start()
    {
        try
        {
            PhotonNetwork.CreateRoom("Room");

        }
        catch
        {
            PhotonNetwork.JoinRoom("Room");

        }
    }


    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("L.E.A.D.E.R");
    }

}
