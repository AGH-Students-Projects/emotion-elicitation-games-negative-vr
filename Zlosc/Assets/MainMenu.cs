using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("VR_GamePlay");
    }
    
    public void Tutorial()
    {
        SceneManager.LoadScene("VR_Tutorial0");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
