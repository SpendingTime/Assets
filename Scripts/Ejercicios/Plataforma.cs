using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float velociti, forci;
    Rigidbody rbd;
    //public bool nani;
    //private Vector3 pose;
    //public GameObject PlataM;
    // Start is called before the first frame update
    void Start()
    {
        rbd = gameObject.GetComponent<Rigidbody>();
        /*if (nani)
        {
            pose = transform.position - PlataM.transform.position;
        }*/
    }
    /*private void LateUpdate()
    {
        transform.position = PlataM.transform.position + pose;
    }*/

    // Update is called once per frame
    void Update()
    {
        Mathf.Clamp(rbd.velocity.z, -velociti, velociti);
        //Debug.Log(rbd.velocity);
    }
    private void FixedUpdate()
    {
        rbd.AddForce(new Vector3(0, 0, 1) * forci / 0.15f);
        if (rbd.velocity.z >= velociti)
        {
            if (rbd.position.z >= 81)
            {
                rbd.velocity = new Vector3(0,0,-velociti*4f);
            }

        }
        //Debug.Log(rbd.velocity);
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            nani = true;
        }
        else nani = false;
    }*/



    /*private void Update()
    {
        transform.position += transform.forward * Time.deltaTime*velocity;
        Debug.Log(rbd.position);
        if (rbd.position == new Vector3(0.0f, 0.0f, 72.0f))
        {
            transform.position -= transform.forward * Time.deltaTime * velocity;
        }
    }*/
    /*{
            rbd.AddForce(new Vector3(0, 0, 1) * -forci/Time.fixedDeltaTime);
        }
        if (rbd.velocity.z == -velocity)
        {
            rbd.AddForce(new Vector3(0, 0, 1) * forci/Time.fixedDeltaTime);
        }*/

}
