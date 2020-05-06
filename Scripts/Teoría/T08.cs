using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T08 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.Operadores logicos
        //========================================
        bool esDeDia = true;
        bool soyProgramador = true;
        bool tengoHambre = false;
        //Operador AND (&&) "Y"
        //Devolver a verdadero si y solo si los dos valores que tiene son true
        //true && true => true
        //true && false => false
        //false && true => false
        //false && false => false
        Debug.Log(soyProgramador && esDeDia);

        //Operador OR (||) "O"
        //Devolvera verdadero si alguno de los valores que tiene es verdadero
        //true || true => true
        //true || false => true
        //false || true => true
        //false || false => false
        bool res = esDeDia || tengoHambre;
        Debug.Log(res);

        //Operador NOT (!) "NO"
        //Invierte el valor logico
        //!true => false
        //!false => true
        //!!false => false
        Debug.Log(!tengoHambre);

        //Operadores encadenados
        Debug.Log(!tengoHambre || (esDeDia&&soyProgramador));

        //2.Operadores de Comparación
        //=========================================
        //== (Es igual a)
        //!= (Es distinto de)
        //> (Mayor que)
        //>= (Mayor o igual)
        //< (Menor que)
        //<= (Menor o igual)
        Debug.Log(4 == 5); //Si se cumple la igualdad dará true
        Debug.Log("Hola" == "hola"); //Para usar el (=) debe haber una variable antes de esto
        Debug.Log(false != false); //Y para hacer equivalencia de tipo logico se usa (==)
        Debug.Log(5 > 4); // true

        bool resultado = 1 <= 10; //true

        Debug.Log(resultado);

        //Enlazar operaciones
        Debug.Log((6>3)||("Pepe"=="pepe"));//true

        string c1 = "Hola";
        string c2 = "Hola";

        Debug.Log(c1 == c2);


    }

   
}
