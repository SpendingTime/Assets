using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E11 : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        int tipoObjetoTocado = 1;
        int Moneda = 0;
        int vidas = 3;

        switch (tipoObjetoTocado)
        {
            case 0: //Se puede depurar paso por paso con step into solo en switch
                Moneda++;
                Debug.Log("Otra moneda más!");
                break;
            case 1:
                vidas--;
                Debug.Log("Pierdes una vida!");
                break;
            case 2:
                vidas++;
                Debug.Log("Ganaste una vida!");
                break;
        }
    }*/

    /*void Start()
    {
        int clave = 3141;
        int[] accesos = { 2, 6, 9 };

        switch (clave)
        {
            case 1234:
                Debug.Log("Usuario ha accedido");
                break;
            case 3141:
                Debug.Log("Editor ha accedido");
                break;
            case 8007:
                Debug.Log("Administrador ha accedido");
                break;
            default:
                Debug.Log("Acceso no permitido!");
                break;


        }
        Debug.Log("Accesos de usuarios: "+accesos[0]);
        Debug.Log("Accesos de editores: " + accesos[1]);
        Debug.Log("Accesos de administradores: " + accesos[2]);
    }*/

    /*void Start()
    {
        int vidas = 3;
        int puntos = 0;
        int tipoObjeto = 4;

        switch (tipoObjeto)
        {
            case 0:
            case 1:
            case 2:
                puntos += 10;
                if (tipoObjeto == 2)
                {
                    Debug.Log("Has encontrado oro!");
                }
                break;
            case 3:
            case 4:
                vidas--;
                break;
            default: Debug.Log("El tipo de objeto "+tipoObjeto+" no existe");
                break;
        }
        Debug.Log("Vidas: "+vidas);
        Debug.Log("Puntos: " + puntos);
    }*/

    void Start()
    {
        int numeroLoteria = 43;
        switch (numeroLoteria)
        {
            case 10:
                Debug.Log("Numero acertado!");
                break;
            case 22:
                Debug.Log("Numero acertad0!");
                break;
            case 43:
                Debug.Log("Numero acertado!");
                break;
            default:
                Debug.Log("Lo siento, pero tu numero no esta entre los agraciados!");
                break;

        }
    }


}
