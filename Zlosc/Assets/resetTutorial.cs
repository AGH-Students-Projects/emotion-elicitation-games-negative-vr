using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetTutorial : MonoBehaviour
{
    public
        //public GameManager GM;
        void OnCollisionEnter(UnityEngine.Collision other)
    {

        //Debug.Log(collisionInfo.collider.name);
        if (other.transform.GetComponent<Collider>().name == "base")
        {
            SceneManager.LoadScene("VR_Tutorial2v2");

            //FindObjectOfType<SCOREBOARD>().UpdateScoreboard();
        }
    }

    private void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change the scene to scene number 3
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
