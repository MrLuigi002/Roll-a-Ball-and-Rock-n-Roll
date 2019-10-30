using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {      
        
    }

    private void LateUpdate()
    {
        Vector3 playerPos = new Vector3(Player.transform.position.x, 20.66f, Player.transform.position.z);
        transform.position = playerPos;
    }
}
