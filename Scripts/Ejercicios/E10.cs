using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E10 : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        int puntuacion = 99;
        bool ganaUnaVida = (puntuacion >= 100);
        if (ganaUnaVida)
        {
            Debug.Log("Has ganado una vida!");
        }



    }*/

    /*void Start()
    {
        int puntos = 0;
        bool doblePuntuacion = true;
        if (doblePuntuacion)
        {
            puntos = puntos + 2; // puntos += 2;
        }
        else
        {
            ++puntos; // puntos += 1; //    puntos = puntos +1;
        }
        Debug.Log(puntos);
    }*/

    /*void Start()
    {
        int edad = 65;
        if (edad >= 60)
        {
            Debug.Log("Se te considera anciano");
        }
        else
            if (edad >= 18)
        {
            Debug.Log("Sete considera adulto");
        }
        else Debug.Log("Se te considera joven");
    }*/

    /*void Start()
    {
        int vidas = 3;
        int monedas = 99;

        if (monedas >= 100)
        {
            monedas -= 100;
            vidas++; // vidas += 1; // vidas = vidas +1;
            Debug.Log("Has ganado una vida! Ahora tienes "+vidas+" vidas");
        }
    }/*

    /*void Start()
    {
        int[] A = { 1, 2, 3 };
        int[] B = { 2, 3, 4 };

        Debug.Log(((A[0] + A[1] + A[2]) % 2 == 0) ? "La suma de los elementos de A es par" : "La suma de los elementos de A es impar");
        Debug.Log(((B[0] + B[1] + B[2]) % 2 == 0) ? "La suma de los elementos de B es par" : "La suma de los elementos de B es impar");
        //El operador ternario " ? "

        /*if ((A[0] + A[1] + A[2]) % 2 == 0)
        {
            Debug.Log("La suma de los elementos de A es par");
        }
        else
        {
            Debug.Log("La suma de los elementos de A es impar");
        }

        if ((B[0] + B[1] + B[2]) % 2 == 0)
        {
            Debug.Log("La suma de los elementos de B es par");
        }
        else
        {
            Debug.Log("La suma de los elementos de B es impar");
        }

    }*/

    void Start()
    {
        if (Random.Range(0, 2) == 0)
        {
            Debug.Log("Cara!");
            int valor = 0;
        }
        else
        {
            Debug.Log("Cruz!");
            int valor = 1;
        }

        //Debug.Log(valor);
    }


}
