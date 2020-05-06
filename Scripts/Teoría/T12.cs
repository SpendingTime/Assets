using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //while
        /*
        int contador = 1;

        while (contador <= 10)
        {
            //Todo el codigo que queremos que se repita
            //mientras la condición es true.
            Debug.Log(contador); //Se le puede agregar un punto de ruptura
            contador++; //indicando en que valor se detendrá
        }
        Debug.Log("Finalizado");*/

        //DO - WHILE    

        int contador = 1;

        do //A diferecia del de arriba, va a ejecutar el contenido al menos una vez
        {  //para recién luego verificar si se esta cumpliendo la variable en while
            Debug.Log(contador);
            int variable = 5; //Si declaras una variable dentro de estas instrucciones no se pueden usar afuera
            contador++; 
        }
        while (contador <= 10);

        Debug.Log("Finalizado!!");

    }

    
}
