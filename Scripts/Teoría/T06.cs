using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T06 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* int puntos01 = 0;
           int puntos02 = 0;
           int puntos03 = 0;
        */

        int[] puntos = new int[10];
        float[] reales = new float[5];
        string[] cadenas = new string[3];
        bool[] logicos = new bool[8];

        int[] InicializadoA = new int[5] { 1, 2, 3, 4, 5 };
        int[] InicializadoB = new int[] { 1, 2, 3, 4, 5 };
        int[] InicializadoC = { 1, 2, 3, 4, 5 };

        float[] RealesInicializado = { 1f, 2f, 3f, 4f, 5f };
        string[] CadenasInicializado = { "Jimena", "Milena", "Cecilia", "Piero" };
        bool[] LogicosInicializando = { true, false, true, true };

        Debug.Log(CadenasInicializado[0]);

        CadenasInicializado[1] = "Diana";

        Debug.Log(CadenasInicializado[1]);

        Debug.Log(CadenasInicializado.Length); // La expresión .Length después del nombre de las variables
                                               // nos muestra la cantidad de elementos, no olvidar el Debug.Log();
                                               // Cuando depuras, en la ventana de inspección puedes ver sus valores con este comando
        
    }
    
}
