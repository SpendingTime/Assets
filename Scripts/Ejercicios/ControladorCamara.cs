using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public GameObject Jugador;
    private Vector3 posicionRelativa;
    // Start is called before the first frame update
    void Start()
    {
        posicionRelativa = transform.position - Jugador.transform.position; //Posición de la camara menos el del Gameobject a seguir
    }

    // Update is called once per frame
    void LateUpdate () //Igual que el Update, pero se ejecuta justo después de todos los Updates
    {
        transform.position = Jugador.transform.position + posicionRelativa;
    }


}
