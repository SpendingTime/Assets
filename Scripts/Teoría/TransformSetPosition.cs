using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSetPosition : MonoBehaviour
{ public float Gamespeed;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        //transform.position += transform.forward * Time.deltatime;(Opcional)
        //Puedes usar esto sin necesidad de que sean Rigidbody(Bastante recomendable)
        //Si el objeto con el script no tiene Rigidbody va a traspasar objetos con o sin Rigidbody
        //Si el objeto con el script tiene Rigidbody no va a traspasar objetos con o sin Rigidbody
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(Horizontal*Gamespeed*Time.deltaTime, 0, Vertical*Gamespeed*Time.deltaTime);
        //transform.position = transform.position + new Vector3(Horizontal * Gamespeed * Time.deltaTime, 0, Vertical * Gamespeed * Time.deltaTime); (Opcional)
    }
}
