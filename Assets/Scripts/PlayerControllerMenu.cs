using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerControllerMenu : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float speed;
    public Text scoreText;
    public bool growMechanic = false;
    public GameObject timetoBuy;
    bool scoreReached = false;
    public int score = 0;
    bool winStatus = false;
    public RawImage winImage;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;    //Resetea la puntuación al iniciar el juego.       
    }

    // Update is called once per frame
    void Update()
    {       
        if (score >= 20 && scoreReached == false)
        {
            scoreReached = true;
            StartCoroutine(ShopCoroutine(timetoBuy));
        }

        if (score >= 23 && winStatus == false)
        {
            winStatus = true;
            StartCoroutine(WinCoroutine());
        }
    }

    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal"); //Detecta movimientos horizontales (A, D, Flecha Derecha, Flecha Izquierda).
        float movementVertical = Input.GetAxis("Vertical");     //Detecta movimientos verticales (W, S, Flecha Arriba, Flecha Abajo).

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);   //Asigna los valores de los movimientos a un Vector
        myRigidbody.AddForce(movement * speed);                                     //Aplica la fuerza al cuerpo

        //scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)         //Se ejecuta cuando hay una colisión contra un Game Object con Trigger activado en su Collider.
    {
        if (other.gameObject.CompareTag("Pickup"))      //Solo se ejecuta si el Game Object tiene el Tag "Pickup" asignado.
        {
            other.gameObject.SetActive(false);          //Desactiva el objeto, dando la ilusión de que se ha destruido.

            score += other.gameObject.GetComponent<Pickup>().value;      //Suma uno a la puntuación al recoger el objeto.
          
            //Debug.Log("Score:" + score);

            if (growMechanic == true)
            {
            transform.localScale += new Vector3((other.gameObject.GetComponent<Pickup>().value * 0.5f), (other.gameObject.GetComponent<Pickup>().value * 0.5f), (other.gameObject.GetComponent<Pickup>().value * 0.5f));
            }
            
        }
    }

    IEnumerator ShopCoroutine(GameObject timetoBuy)
    {
        yield return new WaitForSeconds(10f);
        timetoBuy.gameObject.SetActive(true);
        yield return null;
    }

    IEnumerator WinCoroutine()
    {
        GameObject storePromt = GameObject.FindGameObjectWithTag("StorePromt");

        yield return new WaitForSeconds(2);

        winImage.gameObject.SetActive(true);
        storePromt.gameObject.SetActive(false);

        yield return null;
    }


}
