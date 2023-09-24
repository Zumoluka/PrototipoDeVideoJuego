using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Kill"))
        {
            SceneManager.LoadScene("Game Over");
        }
        if (collision.gameObject.CompareTag("Meta"))
        {
            SceneManager.LoadScene("Win");
        }
    }
    }
}
