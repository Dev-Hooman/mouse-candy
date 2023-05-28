using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthCollider : MonoBehaviour
{
    private int health = 100;
    [SerializeField] public Text healthText;

    private void Start()
    {
        UpdateHealthText();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bomb"))
        {
            health -= 20;
            SoundManager.playExplosionSound();

            Debug.Log("Health decreased to: " + health);
            UpdateHealthText();

            if (health <= 0)
            {
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
                Debug.Log("Game Over!");
                
            }

            Destroy(other.gameObject);
        }

        if (other.CompareTag("health"))
        {
            Debug.Log("Enter in Health");
            SoundManager.playHealthSound();

            if (health < 100)
            {
                health += 10;
                Debug.Log("Health increased to: " + health);
                UpdateHealthText();
            }

            Destroy(other.gameObject);
        }
    }

    private void UpdateHealthText()
    {
        healthText.text = "Health: " + health;

        if (health < 40)
        {
            healthText.color = Color.red;
        }
        else
        {
            healthText.color = Color.green;
        }
    }
}
