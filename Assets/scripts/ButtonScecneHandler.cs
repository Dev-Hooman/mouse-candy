using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScecneHandler : MonoBehaviour
{
    public void onCLickPlay()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }


    public void onClickHome()
    {
        SceneManager.LoadScene("LoadingScene", LoadSceneMode.Single);

    }

    public void onClickResume()
    {
        //Scene Resume and load main scene
    }


}