using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public GameObject Player;
    public Vector3 offset = new Vector3(0, 0, 0);

    Animator animator;
    bool menuState = false;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        menuState = false;
    }

    
    void Update()
    {
        Vector3 playerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z) + offset;
        transform.position = playerPos;

        if(Input.GetKeyDown(KeyCode.Return) && menuState == false)
        {
            menuState = true;
            animator.SetTrigger("Appear");
        }
    }
}
