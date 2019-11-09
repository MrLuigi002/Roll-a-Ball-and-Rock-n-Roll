using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);

    Animator animator;
    bool menuState = false;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
        menuState = false;
    }

    
    void Update()
    {
        Vector3 playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z) + offset;
        transform.position = playerPos;

        if(Input.GetKeyDown(KeyCode.Return) && menuState == false)
        {
            menuState = true;
            animator.SetTrigger("Appear");
        }
    }
}
