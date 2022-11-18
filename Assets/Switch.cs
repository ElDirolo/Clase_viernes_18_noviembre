using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int numero;

    public bool boleana;
    public string texto;
    
    // Start is called before the first frame update
    void Start()
    {
        /*if (numero == 8 && boleana == true)
        {
            Debug.Log("numero 8 y true");
        }*/

        //
        switch (numero)
        {
            case 0:
                Debug.Log("0");
                transform.position = new Vector3(0,0,0);
            break;

            case 1:
                Debug.Log("1");
            break;

            case 2:
                Debug.Log("2");
            break;

            case 3:
                Debug.Log("3");
            break;

            case 4:
                Debug.Log("4");
            break;

            default:
                Debug.Log("sin numero");
            break;
        }

        switch (texto)
        {
            case "pedro":
                Debug.Log("Hola pedro");
            break;

            case "Juan":
                Debug.Log("Hola Juan");
            break;

            case "Manolo":
                Debug.Log("Hola Manolo");
            break;

            default:
                Debug.Log("Quien eres");
            break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
