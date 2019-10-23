using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void Empezar(string Sellos)
    {
        print ("Sellos camera"+ Sellos);
        SceneManager.LoadScene(Sellos);
    }
    public void Principal(string Principal)
    {
        print ("Principal Menu"+ Principal);
        SceneManager.LoadScene(Principal);
    }
    public void Terms ()
    {
         Application.OpenURL("https://drive.google.com/file/d/1345MC8f6ieczOzwXIhzk6VVgYnucYHQT/view?usp=sharing");
    }
    public void Exit ()
    {
        Application.Quit();
    }
}
