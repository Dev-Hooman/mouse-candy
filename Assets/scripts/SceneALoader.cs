using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneALoader : MonoBehaviour
{
    float timer = 0.0f;
    bool escapePressed = false;

    void Update()
    {
        // Stop
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("STOP");

            escapePressed = true;
        }

        // Start
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Start");

            escapePressed = false;
        }


        if (!escapePressed)
        {
            // In above Condition I
            // just load the scene after 10 seconds, but only if the Escape key hasn't been pressed

            timer += Time.deltaTime;
            if (timer >= 3)
            {
                SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
                timer = 0.0f;
            }
        }
    }
}
