using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyAddForce : MonoBehaviour
{
    Rigidbody rbd;
    public float Fuerza;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //rbd.AddForce(transform.forward*fuerza*Time.deltaTime); (Opcional)
        //Este Objeto no va a traspasar objetos, pero va a interactuar físicamente con objetos que tmb tengan Rigidbody
        //Si al objeto con el script le agregamos la opcion "Is Kinematic" no avanzará debido a que se anulan todo tipo de fuerzas
    }
    private void FixedUpdate()
    {
        //rbd.AddForce(transform.forward * fuerza * Time.fixedDeltaTime); (Opcional)
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        rbd.AddForce(new Vector3(Horizontal, 0, Vertical)* Fuerza * Time.fixedDeltaTime);
    }
}
