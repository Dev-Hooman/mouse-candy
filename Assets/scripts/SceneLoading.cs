using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float timer = 0.0f;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >3)
        {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
            timer = 0.0f;
        }




    }
}
