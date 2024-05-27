using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Cuando el usuario presione el botón BtnAceptar
//debe escribirse un mensaje en la consola
//si el texto de input Password coincide
//con una contraseña predefinida por ustedes
//escribir "Access Granted"
//sino escribir "Acces Denied"
public class LoginManager : MonoBehaviour
{
    public InputField Input_Password;
    public string Password;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void contraseña()
    {
        if (Input_Password.text == Password)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Access Denied");
        }
    }
}
