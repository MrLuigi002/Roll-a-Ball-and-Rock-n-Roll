using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    public GameObject musicPlaying;
    bool appearNow = false;
    bool wao = false;

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

        appearNow = musicPlaying.GetComponent<OverlayTextScript>().avanced;

        if(Input.GetKeyDown(KeyCode.Return) && menuState == false)
        {
            menuState = true;     
        }

        if(appearNow && !wao)
        {
            animator.SetTrigger("Appear");
        }
    }

    
}
