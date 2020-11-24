using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Toggle toggle = null;
    public void GuardarOpcion()
    {
        if (toggle.isOn)
        {
            print("Activado VR");
        }
        else
        {
            print("Desactivado VR");
        }
    }
    public void CambiarScene(int index)
    {
        SceneManager.LoadScene(index);
    }

}
