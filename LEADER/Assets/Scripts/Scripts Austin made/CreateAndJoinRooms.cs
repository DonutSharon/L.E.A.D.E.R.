using Photon.Pun;using Photon.Realtime;using static isInstructor;public class CreateAndJoinRooms : MonoBehaviourPunCallbacks{    // Start is called before the first frame update    public byte MaxPlayersPerRoom = 4;    public void Start()    {
           isInstructor.Instructor = false;           PhotonNetwork.JoinRoom("Room");
        PhotonNetwork.LoadLevel("L.E.A.D.E.R");


    }}