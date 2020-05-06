using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    public float Gamespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(1,0,0) * Time.deltaTime);(Opcional)
        //Puedes usar esto sin necesidad de que sean Rigidbody
        //No va a traspasar objetos si y solo si ambos tienen Rigidbody
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(Horizontal * Gamespeed * Time.deltaTime, 0, Vertical * Gamespeed * Time.deltaTime));
    }
}
