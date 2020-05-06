using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E12 : MonoBehaviour
{

    // Start is called before the first frame update
    /*void Start()
    {
        int contador = 0;
        
        while (contador <= 9)
        {
            contador++;
            Debug.Log("Hola! ("+ contador+")");
        }
    }*/

    /*void Start()
    {
        int tablaDeMultiplicar = 1;
        int contador = 1;

        while (tablaDeMultiplicar <= 10)
        {
            contador = 1;
            while (contador <= 10)
            {
                Debug.Log(tablaDeMultiplicar + " * " + contador + "=" + (contador*tablaDeMultiplicar));
                contador++;
            }
            tablaDeMultiplicar++;
        }
    }*/

    /*void Start()
    {
        string[] mensajes = {"Esto es", "un ejemplo", "de como", "se pueden", "recorrer todos", "los elementos", "de un array", "fin!!" };
        int a = 0;
        while (a < mensajes.Length)
        {
            Debug.Log(mensajes[a]);
            a++;
        }
    }*/

    void Start()
    {
        int contador = 1;
        string lista = "";
        while (contador <= 10)
        {
            lista += "[" + contador + "]"; // lista = lista + "[" + contador + "]";
            Debug.Log("Paso: " + (contador++));
        }
        Debug.Log(lista);
    }


}
