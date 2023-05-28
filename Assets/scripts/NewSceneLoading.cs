using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneLoading : MonoBehaviour
{
    [SerializeField] private string sceneAName;
    [SerializeField] private string sceneBName;
    [SerializeField] private float sceneDuration;

    private bool isSceneA = true;
    private float timer = 0.0f;

    private void Start()
    {
        if (string.IsNullOrEmpty(sceneAName))
        {
            Debug.LogError("SceneLoader: Scene A name is not set.");
            return;
        }

        if (string.IsNullOrEmpty(sceneBName))
        {
            Debug.LogError("SceneLoader: Scene B name is not set.");
            return;
        }

        if (sceneDuration <= 0.0f)
        {
            Debug.LogError("SceneLoader: Scene duration must be greater than zero.");
            return;
        }

        SceneManager.LoadScene(sceneAName);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= sceneDuration)
        {
            if (isSceneA)
            {
                SceneManager.LoadScene(sceneBName);
            }
            else
            {
                SceneManager.LoadScene(sceneAName);
            }

            isSceneA = !isSceneA;
            timer = 0.0f;
        }
    }
}
