using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStoreScript : MonoBehaviour
{
    public GameObject storeWindow;
    public bool active;

    public void OpenStore(GameObject storeWindow)
    {
        if (!active)
        {
            storeWindow.gameObject.SetActive(true);
            active = true;
        }

        else
        {
            storeWindow.gameObject.SetActive(false);
            active = false;
        }
    }

    
}
