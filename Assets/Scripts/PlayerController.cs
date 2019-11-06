using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed;
    public int score;
    public TextMeshPro scoreSet;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;    //Resetea la puntuación al iniciar el juego.
    }

    // Update is called once per frame
    void Update()
    {       
    }

    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal"); //Detecta movimientos horizontales (A, D, Flecha Derecha, Flecha Izquierda).
        float movementVertical = Input.GetAxis("Vertical");     //Detecta movimientos verticales (W, S, Flecha Arriba, Flecha Abajo).

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);   //Asigna los valores de los movimientos a un Vector
        myRigidbody.AddForce(movement * speed);                                     //Aplica la fuerza al cuerpo
    }

    private void OnTriggerEnter(Collider other)         //Se ejecuta cuando hay una colisión contra un Game Object con Trigger activado en su Collider.
    {
        if (other.gameObject.CompareTag("Pickup"))      //Solo se ejecuta si el Game Object tiene el Tag "Pickup" asignado.
        {
            other.gameObject.SetActive(false);          //Desactiva el objeto, dando la ilusión de que se ha destruido.

            score += other.gameObject.GetComponent<Pickup>().value;      //Suma uno a la puntuación al recoger el objeto.
                       
            scoreSet.SetText("Score: {0}", score);
            
            //Debug.Log("Score:" + score);
        }
    }


}
