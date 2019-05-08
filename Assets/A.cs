using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class A : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void CambiarEscena1(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }
    public void SALIR(string nombre)
    {
        Application.Quit();
    }
}
