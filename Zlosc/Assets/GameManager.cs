using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool gameHasEnded = false;
    public Score GameScore;

    public void EndGame()
    {
        if (gameHasEnded) return;
        
        //delay = Time.time;
        gameHasEnded = true;
        Debug.Log("Koniec giereczki");
        Restart();
    }

    private void Restart()
    {
        //FindObjectOfType<Score>().delay = Time.time;
        SceneManager.LoadScene("Scenes/VRGameOver");
    }
}
