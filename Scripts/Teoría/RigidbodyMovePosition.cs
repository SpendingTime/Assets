using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovePosition : MonoBehaviour
{
    Rigidbody rbd;
    public float Gamespeed;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rbd.MovePosition(transform.position + (transform.forward * Time.deltaTime*10)); (Opcional)
        //Este Objeto no va a traspasar objetos, pero va a interactuar físicamente con objetos que tmb tengan Rigidbody
        //Poco comun de usar

        //Vector3 newPosition = transform.position + (transform.forward * Time.deltaTime * 10);
        //rbd.MovePosition(newPosition); (Opcional)

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        rbd.MovePosition(transform.position + new Vector3(Horizontal, 0, Vertical) * Time.deltaTime * Gamespeed);
    }
}
