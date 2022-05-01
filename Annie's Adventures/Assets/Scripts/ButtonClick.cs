using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Bibliotecas

public class ButtonClick : MonoBehaviour
{
   public string Fase;
    public void Click()
    {
         SceneManager.LoadScene(Fase);
	   ScriptController.userPoints=0;
	   ScriptController.userLife=10;

    }
    public void PularCena()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Exit(){
      Application.Quit();  
      UnityEditor.EditorApplication.isPlaying = false;  
    }


}
