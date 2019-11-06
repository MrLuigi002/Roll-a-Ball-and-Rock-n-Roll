using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset = new Vector3(0, 20.66f, -8.67f);
    
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
        Vector3 playerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z) + offset;
        transform.position = playerPos;
    }
}
