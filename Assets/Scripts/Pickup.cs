using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(15, 30, 45) * Time.deltaTime; //La rotación deseada por el tiempo pasado desde el último frame,
                                                                     //para que el movimiento no sea dependiente de los FPS.
        transform.Rotate(rotation);
    }
}
