using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class EndScene : MonoBehaviour
{
    [SerializeField] private Text foodScore;

    void Start()
    {
        int foodCount = PlayerPrefs.GetInt("FoodCount");

        foodScore.text = "Score: " + foodCount.ToString();
    }


}
