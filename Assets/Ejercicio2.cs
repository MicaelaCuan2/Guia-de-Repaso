using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{
    public Text TextIngresado;
    public Text Texto;
    public bool VacioONo;
    void Start()
    {
        VacioONo = true;
    }
    public void ShowMessage()
    {
        if (VacioONo == true)
        {
            Debug.Log("Error, ingrese texto");
        }
        else if (VacioONo == false)
        {
            TextIngresado.text = Texto.text;
        }
    }
}
