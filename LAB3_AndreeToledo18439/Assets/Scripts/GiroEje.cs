using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Andree Toledo18439
public class GiroEje : MonoBehaviour
{
    public int speed = 350;
    private Vector3 miVector;
    // Start is called before the first frame update
    void Start()
    {
        miVector = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
