using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Andree Toledo18439
public class Respawn : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody Prefab;
    private Vector3 miVector;

    void Start()
    {
        miVector = new Vector3(-7, 1, -8);
    }
    void OnTriggerEnter()
    {
        if (Input.GetKey(KeyCode.Q))
            Instantiate(Prefab, miVector, Spawnpoint.rotation);
    }

}
