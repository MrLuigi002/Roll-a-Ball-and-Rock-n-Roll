using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Animator anim;
    bool lightState = false;
    //int lightHash = Animator.StringToHash("Switch");


    void Awake()
    {
        
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        lightState = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && lightState == false)
        {
            lightState = true;
            anim.SetTrigger ("Switch");
        }
    }
}
