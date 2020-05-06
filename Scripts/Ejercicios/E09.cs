using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E09 : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        int a = 0;
        a = a + 1;
        a += 1;
        ++a;

        Debug.Log(a);

    }*/

    /*void Start()
    {
        int a = 10;
        int b = a--;

        Debug.Log("a= "+a+" b= "+b);
    }*/

    /*void Start()
    {
        int edad = 17;
        string texto = (edad >= 18) ? "Mayor de edad" : "Menor de edad";

        Debug.Log(texto);
    }*/

    /*void Start()
    {
        int cont = 0;

        int a = ++cont;
        int b = cont++;

        string texto = (a == 1 && b == 1 && cont == 2) ? "Lo he entendido!" : "Sigo sin entenderlo... :(";

        Debug.Log(texto); //En la consola saldrá: Lo he entendido!
    }*/

    void Start()
    {
        int cont = 0;

        ++cont;

        Debug.Log(((++cont)==2) ? "cont vale 2" : "cont no vale 2");
    }


}
