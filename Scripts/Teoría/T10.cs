using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Condicional if (si) / else (sino)

        //if (Expresión que se resuelve en un valor logico)
        //Instruccion a ejecutar en caso de que la expresión sea true
        //else 
        //Instruccion a ejecutar en caso de que la expresión sea false
        //Expresion: true | false | | variable lógica | comparación...

        int edad = 19;
        if (edad >= 18)
        {
            int a = 5; // Si definimos una variable dentro del corchete, solo podra utilizarse ahí
            Debug.Log("Eres mayor de edad");
            Debug.Log("Instrucción adicional (true)");
            Debug.Log(a); // Si hago un log de esta variable fuera de los corchetes nos devolverá error
        }
        else
        if (edad <= 0)
        {
            Debug.Log("Todavia no ha nacido");
        }
        else
            Debug.Log("Has nacido y eres menor de edad");

        Debug.Log("Programa finalizado");
        
    }

    
}
