using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E08 : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        bool a = false;
        bool b = !!a;

        Debug.Log(b);
    }*/

    /*void Start()
    {
        bool trueANDtrue = true && true;
        bool trueANDfalse = true && false;
        bool falseANDtrue = false && true;
        bool falseANDfalse = false && false;

        Debug.Log("true && true = " + trueANDtrue); //true
        Debug.Log("true && false = " + trueANDfalse); //false
        Debug.Log("false && true = " + falseANDtrue); //false
        Debug.Log("false && false = " + falseANDfalse); //false

        bool trueORtrue = true || true; //true
        bool trueORfalse = true || false; //true
        bool falseORtrue = false || true; //true
        bool falseORfalse = false || false; //false

        Debug.Log("true || true = "+ trueORtrue);
        Debug.Log("true || false = " + trueORfalse);
        Debug.Log("true || true = " + falseORtrue);
        Debug.Log("true || true = " + falseORfalse);

    }*/

    /*void Start()
    {
        bool estoyProgramando = true;
        bool vivoenMarte = false;
        bool youtubeEmpiezaporY = true;

        bool resultado1 = estoyProgramando && !vivoenMarte;
        bool resultado2 = vivoenMarte || (estoyProgramando && youtubeEmpiezaporY);
        bool resultado3 = !((!estoyProgramando || vivoenMarte) || !youtubeEmpiezaporY);

        Debug.Log("Resultado 1: "+resultado1); //true
        Debug.Log("Resultado 2: "+resultado2); //true
        Debug.Log("Resultado 3: "+resultado3); //true
        
    }*/

    /*void Start()
    {
        int edad = 17;
        bool dentroDelIntervalo = (18 <= edad && edad <= 30) ;

        Debug.Log("¿Esta el valor "+edad+" comprendido dentro de los 18 y 30 años? : "+dentroDelIntervalo);

        bool FueraDelIntervalo = (edad < 18) || (30 < edad);

        Debug.Log("¿Esta el valor " + edad + " comprendido fuera de los 18 y 30 años? : " + FueraDelIntervalo);


    }*/

    void Start()
    {
        bool esDeDia = true;
        bool vivoEnMarte = false;
        int edad = 20;

        bool resultado = ((esDeDia || vivoEnMarte));
        bool noTiene20 = !(edad == 20);

        Debug.Log("Resultado: "+resultado+" No Tiene 20: "+noTiene20);

    }


}
