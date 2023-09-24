using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class intento : MonoBehaviour

{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Item"))
        {
            Debug.Log("Agarraste un item");
            score++;
            scoreText.text = score.ToString();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kill")
        {
            SceneManager.LoadScene("Game Over");
        }
        if (other.gameObject.tag == "Item")
        {
            Debug.Log("Agarraste un item");
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Meta")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
