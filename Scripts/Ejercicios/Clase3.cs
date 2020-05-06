using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Clase3 : MonoBehaviour

{
    Rigidbody rbd, ans;
    public float velocidad, fuerzaSalto;//fuerza,
    public float x, z; //X, Z;
    int contador;
    public bool nani;
    public GameObject OBJ, monedaAu, audiosal;
    public Text Puntuación, final, bienvenida, fail;
    public RawImage Waifu;
    

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        ans = OBJ.GetComponent<Rigidbody>();
        contador = 0;
        ActualizarMarcador();
        
        
    }
    private void Awake()
    {
        final.gameObject.SetActive(false);
        Waifu.gameObject.SetActive(false);
        bienvenida.gameObject.SetActive(false);
        fail.gameObject.SetActive(false);
        monedaAu.gameObject.SetActive(false);
        audiosal.gameObject.SetActive(false);
        
    }

    private void ActualizarMarcador() //Puedes usar métodos para agrupar codigos que se usan varias veces, y asi modificarlos a todos a la vez
    {
        Puntuación.text = "Coins: " + contador;
    }

    // Update is called once per frame
    void Update()
    { if (rbd.velocity.y == 0)
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
            rbd.velocity = new Vector3(x * velocidad, rbd.velocity.y, rbd.velocity.z);
            rbd.velocity = new Vector3(rbd.velocity.x, rbd.velocity.y, z * velocidad);
        }
    if (nani)
        {
            x = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");
            rbd.velocity = new Vector3(x * velocidad, rbd.velocity.y, rbd.velocity.z + ans.velocity.z);
            rbd.velocity = new Vector3(rbd.velocity.x, rbd.velocity.y, z * velocidad + ans.velocity.z);
        }
        //Debug.Log(rbd.velocity.y);
        /*X = Mathf.Clamp(rbd.velocity.x, -velocidad, velocidad); //Le da a un valor que se pone al inicio,los valores maximos y minimos en os siguientes 2 casillas
        Z = Mathf.Clamp(rbd.velocity.z, -velocidad, velocidad);*/ //Por ejemplo Mathf.Clamp(float value, Mín, Máx)
        if (rbd.position.y <= -30)
        {
            SceneManager.LoadScene("Clase 3");
        }

        
        


    }
    private void FixedUpdate()
    {
        /*rbd.AddForce(new Vector3(x * fuerza, 0, 0));
        rbd.AddForce(new Vector3(0, 0, z*fuerza));
        
        rbd.velocity = new Vector3(X, rbd.velocity.y, Z);*/

        if ((Input.GetKey(KeyCode.Space) && rbd.velocity.y == 0))
        {
            audiosal.gameObject.SetActive(true);
            Instantiate(audiosal);
            rbd.AddForce(new Vector3(0, 1, 0) * fuerzaSalto / Time.fixedDeltaTime);
        }
        if (nani)
        {
            if (Input.GetKey(KeyCode.Space) && (rbd.velocity.y <= 0.2f && rbd.velocity.y >= -0.2f))
            {
                audiosal.gameObject.SetActive(true);
                Instantiate(audiosal);
                rbd.AddForce(new Vector3(0, 1, 0) * fuerzaSalto/ Time.fixedDeltaTime);
            }
        }


    }

    private void OnCollisionEnter(Collision collision)
    { if (collision.gameObject.CompareTag("Cube2"))
        { rbd.AddForce(new Vector3(0, 1, 0) * 23 / Time.fixedDeltaTime); }

     if (collision.gameObject.CompareTag("moneda"))
        {
            monedaAu.gameObject.SetActive(true);
            Instantiate(monedaAu);
            Destroy(collision.gameObject);
            contador++;
            ActualizarMarcador();
        }

        if (collision.gameObject.CompareTag("plataforma"))
        {
            nani = true;
        }
        else { nani = false; }

        if ((contador <=11) && (rbd.position.z >= 100) && (rbd.velocity.magnitude <=1))
        {
            fail.gameObject.SetActive(true);
            fail.text = "A donde vas sin mis 12 monedas Onee-chan!";
            Waifu.gameObject.SetActive(true);
            final.gameObject.SetActive(false);
        }

        if (contador >= 12)
        {
            final.gameObject.SetActive(true);
            final.text = "Ganaste rufián!!";
            Waifu.gameObject.SetActive(true);
            fail.gameObject.SetActive(false);
        }
        


    }
   
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("plataforma"))
            nani = false;
        
    }




}
