using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySetVelocity : MonoBehaviour
{
    Rigidbody rbd;
    public float Gamespeed;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        //rbd.velocity = transform.forward * Time.deltaTime * Gamespeed; (Si deseas que tu objeto desde el inicio se mueva)
    }

    // Update is called once per frame
    void Update()
    {
        //rbd.velocity = transform.forward * Time.deltaTime * Gamespeed; (Opcional)
        //Este Objeto no va a traspasar objetos, pero va a interactuar físicamente con objetos que tmb tengan Rigidbody

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        rbd.velocity = new Vector3(Horizontal ,0 ,Vertical)*Gamespeed*Time.deltaTime;

    }
}
