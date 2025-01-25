using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeT1T2 : MonoBehaviour
{
    private void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change the scene to scene number 3
            SceneManager.LoadScene("VR_Tutorial2v2");
        }
    }
}
