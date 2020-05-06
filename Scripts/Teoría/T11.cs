using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SWITCH
        
        int tipoObjetoTocado = 2; // 0 -> moneda y da vida, 1 -> enemigo y quita vidas
        int vidas = 5;

        switch (tipoObjetoTocado)
        {
            case 0:
                Debug.Log("Has ganado una vida");
                vidas++;
                break;
            case 1:
                Debug.Log("Has perdido una vida");
                vidas--;
                break;

            default: //Se usa en caso no coincida con alguno de los casos msotrados
                Debug.Log("Tipo de objeto no reconocido");
                break;
        } 
    }

    
}
