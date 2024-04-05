using UnityEngine;
using Photon.Pun;
using static isInstructor;


public class Spawnplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
    public GameObject InstructorPrefab;
    public float x;
    public float y;
    public float z;
    // Update is called once per frame
    private void Start()
    {
        if (isInstructor.Instructor)
        {


            Vector3 position = new Vector3(x, y, z);
            PhotonNetwork.Instantiate(InstructorPrefab.name, position, Quaternion.identity);
        }
        else
        {
            Vector3 position = new Vector3(x, y, z);
            PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
        }
    }
}

