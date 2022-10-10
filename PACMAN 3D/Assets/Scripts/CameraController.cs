using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;

    [SerializeField]
    private bool switchCam = false;

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            switchCam = !switchCam;
        }
        if(switchCam)
        {
            transform.position = player.transform.position + new Vector3(0, -7.2f, 6.5f);
        }
        if(switchCam == false){
            transform.position = new Vector3(0, 0.3f, -0.5f);
        }
        
    }
}