using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*int puntosMaximos = 100;
        int puntos = 0;

        puntos = 10; //siempre que hay un igual, a la izquierda va una variable.
        puntos = 20;
        puntos = puntosMaximos;
        puntos = puntos;

        //Asignación en cadena
        int a = 0, b = 0, c = 0;
        a = b = c = 10;*/

        //Operadores matemáticos -, +, /, *, %
        int a = 0, b = 0, c = 0;
        a = 1 + 2 + 3 + 4; //a=10
        b = a * 2;         //b=20
        b = b + 1;         //b=21
        b = b + 1;         //b=22
        b = b + 1;         //b=23
        a = a / 2;         //a=5
        b = b - 1;         //b=22
        c = 2 % 1;         //c = 0, ya que este es su resto
        c = 3 % 2;         //c = 1, ya que este es su resto

        string c1 = "Hola marcianos";
        string c2 = "Como estais";
        string res = c1 + c2;

        Debug.Log(res); //el simbolo mas sirve tambien para agrupar cadenas de textos   
                        //Se recomienda usar paréntesis para hacer las operaciones meatemáticas
    }

   
}
