using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Consigna:

Heladería "Los tres gustos"

Esta heladería ofrece 3 gustos: chocolate, frutilla y dulce de leche y toma pedidos mediante códigos. 
El cliente debe pedir los gustos ingresando CHO, FRU y DDL. Además debe ingresar una cantidad de helado en gramos (250 para un cuarto, 500 para medio k, etc). Esta semana tiene una promoción con frutilla, por lo que el precio se reduce un %10 solo en ese gusto.

. Mostrar un mensaje de error y ningún otro mensaje ni realizar ningún cálculo si no se ingresa un código válido o si las cantidades de helado son menores a 250 o mayores que 3000. 

. Sabiendo que el kilo de helado sale $500, devolver el costo del pedido si los ingresos son válidos. Recuerdo contemplar la promoción.

*/
public class Heladeria : MonoBehaviour
{
    public string helado;
    public int gramos;
    // Start is called before the first frame update
    void Start()
    {
        float precio = gramos / 2;
        float precioFRU = (precio / 100) * 90;
        if (gramos > 3000 || gramos < 249)
        {
            Debug.Log("Ingresa menos gramos a 3000 o mas de 250");
        }
        else
        {
            if (helado == "DDL" || helado == "CHO")
            {
                Debug.Log("El precio va a ser " + precio);

            }
            else if (helado == "FRU")
            {
                Debug.Log("El precio va a ser " + precioFRU);
            }
            else
            {
                Debug.Log("El gusto ingresado no es valido.");
            }
        }
                }
    

    // Update is called once per frame
    void Update()
    {
        
    }
   }
