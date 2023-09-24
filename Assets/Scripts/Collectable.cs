using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Collectable : MonoBehaviour
{
    public Text objectsRemainingText;
    public GameObject winMessage;
    private int totalObjects;

    void Start()
    {
        totalObjects = GameObject.FindGameObjectsWithTag("Item").Length;
        UpdateUI();
        winMessage.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            totalObjects--;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        objectsRemainingText.text = "Items Restantes: " + totalObjects;

        if (totalObjects == 0)
        {
            winMessage.SetActive(true);
        }
    }
}



