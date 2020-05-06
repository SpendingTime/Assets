using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T09 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Operadores: +=, -=, *=, /=, %=
        int puntos = 0;

        puntos = puntos + 1;

        puntos += 1;

        //Las siguientes dos lìneas hacen exactamente lo mismo
        puntos = puntos * 10;
        puntos *= 10;

        //Los operadores ++, -- vas a sumar o restar 1 a nuestras variables

        int vidas = 0;

        //vidas = vidas - 1;
        //vidas -= 1;
        //vidas--; //Delas 2 formas son válidas
        //--vidas; //Vidas tendràn una unidad menos
        int a = ++vidas;
        //Debug.Log("A: "+a); //El orden de poner el ++ o el --, dependerá si primero vota el valor
        //Debug.Log("Valor Final: "+vidas); // y luego lo cambia o viceversa.

        // Operador: ?: Esta formado por una expresión lógica y la interrogante con un valor seguido de dos puntos y otro valor

        int edad = 17; //Si la edad es menor que dieciocho entonces devuelve un valor 10 sino devolverá 50
        int dificultad = (edad < 18) ? 10 : 50;

        string mensaje = (vidas <= 0) ? "Game over" : "Todavia te queda vidas";
        Debug.Log(mensaje);


    }

    
}
