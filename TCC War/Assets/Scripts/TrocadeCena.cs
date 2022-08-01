using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocadeCena : MonoBehaviour
{
    public string NomedaCena;
   public void ChangeS()
    {
        SceneManager.LoadScene(NomedaCena);
    }
    
    public void Sair()
    {
        Application.Quit();
    }
}
