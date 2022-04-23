using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseñaUsuario;
    public Text texto_Msj;
    public Text ingresoUsuario;
    public GameObject cartel_Msj;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
        cartel_Msj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContra()
    {

        contraseñaUsuario = ingresoUsuario.text;
        
        if (contraseñaUsuario == contraseniaCorrecta)
        {
            cartel_Msj.SetActive(true);
            texto_Msj.text = "Bienvenido";
            Debug.Log("Bienvenido");

        }

        else
        {
            cartel_Msj.SetActive(true);
            texto_Msj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }

    }
}
