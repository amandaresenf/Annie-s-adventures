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
    }
    public void Exit(){
      Application.Quit();  
      UnityEditor.EditorApplication.isPlaying = false;  
    }


}
