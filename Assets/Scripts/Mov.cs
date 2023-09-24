using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{

    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;


    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()

    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Choque contra: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Item"))
        {

            Debug.Log("ITEMMM >>>>>>>>>>>>>>>>");

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Kill"))
        {

            SceneManager.LoadScene(0);

        }
    }
    /*private void OnTriggerEnter(Collider other)
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
        }
    }
    */
}