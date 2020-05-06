using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        // Tipo de datos mas comunes:

        // Numeros enteros: int
        // 1, 4, 5, -5, 1000, 0, etc.

        // Numeros reales: float
        /* 3.1415f, 56.4f, 0.5f, -24.75f, etc. Le agregamos "f" al final 
           de cada numero con decimales */

        // Cadenas de texto: string
        // "Hola mundo", "Antonio", "Maria",etc.

        // Valores lógicos: bool - Puede tener 2 valores lógicos
        // true == verdadero, false == falso

        //Ejemplo de declaración de variables
        int puntos = 0;
        float notaExamen = 17.45f;
        string nombreJugador = "Peluchín";
        bool personajeVivo = true;

        Debug.Log(puntos);
        Debug.Log(notaExamen);
        Debug.Log(nombreJugador);
        Debug.Log(personajeVivo);

        string mensaje = "Esto \\no es un \"simulacro\"\n:v"; /*Si quiero agregar comillas 
        dentro del texto, le agrego \"---\" y si deseas agregar un \ le ponemos doble \\ */
        Debug.Log(mensaje);

        /*int edadMax = 13;
        int edadJavier = 15;
        int edadJulia = 11;*/
        //Para definir variables del mismo tipo en una sola linea
        //int edadMilena = 13, edadAna = 15, edadAnita = 11;

        //Modificar el contenido de una variable "="
        puntos = 100; //Aqui los puntos ya valdrán 100
        personajeVivo = false;
        
        Debug.Log(puntos);

        puntos = 200; //Aqui los puntos ya valdrán 200
        personajeVivo = true;

        Debug.Log(puntos);

        //Ámbitos de variables
        {
            int a = 0;
            //int c = 5;
            Debug.Log(a);
            {
                int b = 4;
                Debug.Log(a);
                Debug.Log(b);
            }
        }
        /*Aqui fuera de los corchetes la variable "a" ya no existiría
        y esta instrucción daría un error: Debug.Log(a); */
        

    }


}
