using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int dia;
    public string codigo;
    
    // Start is called before the first frame update
    void Start()
    {
        int G = dia * 300;
        int PP = dia * 400;
        int PG = dia * 700;
        int precioG = G / 100 * 80;
        int precioPP = PP / 100 * 80;
        int precioPG = PG / 100 * 80;

        if (dia < 3)
        {
            Debug.Log("La cantidad de dias debera ser mayor a tres");
        }
        if (codigo != "G" && codigo != "PP" && codigo != "PG")
        {
            Debug.Log("El codigo ingresado no es valido");
        }
        else if(codigo == "G")
        {
            Debug.Log("Para ese periodo se necesitan " + G + " y saldra " + precioG);
        }
        else if (codigo == "PP")
        {
            Debug.Log("Para ese periodo se necesitan " + PP + " y saldra " + precioPP);
        }
        else if (codigo == "PG")
        {
            Debug.Log("Para ese periodo se necesitan " + PG + " y saldra " + precioPG);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
