using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Andree Toledo18439
public class Mover : MonoBehaviour
{
    public Text score;
    // Start is called before the first frame update

    //Declaramos la variable velocidad para modificarla y aplicarle movimiento a la pelota
    public float speed;
    //La variable fuerza se declara para poder medir con que fuerza el salto
    public int force = 3;
    public int contador = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //Creamos una funcion para poder saltar modificando la posicion de nuestro objeto
        Vector3 escala = new Vector3(1, 1, 1);
        if (Input.GetKey(KeyCode.Return))
            transform.localScale += escala * 2 * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.005f)
            Saltar();

    }
    private void Saltar()
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
     void OnTriggerEnter(Collider other)
    {
        //Esta funcion hace que nuestro GameObejct "recoga un objeto con el tag pick up y estos desaparecen no apareciendo renderizados
        Destroy(other.gameObject);
        contador += 1;
        score.text = "PUNTUAJE: " + contador.ToString();
    }
    void OnCollisionEnter(Collision other)
    {
        //Esta funcion hace que nuestro GameObejct desaparezca al tocar un objeto con el tag lava
        if (other.gameObject.tag == "lava" && contador <=2)
        
            Destroy(gameObject, .5f);

    }



}
