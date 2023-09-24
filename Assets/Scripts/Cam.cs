using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 
    public Transform objetivo; // El objeto que la cámara seguirá

    public float suavidad = 5.0f; // La suavidad del seguimiento, ajusta según sea necesario

    private Vector3 offset; // Distancia inicial entre la cámara y el objetivo

    void Start()
    {
        if (objetivo == null)
        {
            Debug.LogError("No se ha establecido un objetivo para la cámara.");
            return;
        }

        offset = transform.position - objetivo.position;
    }

    void LateUpdate()
    {
        if (objetivo == null)
            return;

        // Calcula la posición deseada de la cámara basada en la posición actual del objetivo y el offset inicial
        Vector3 posicionDeseada = objetivo.position + offset;

        // Interpola suavemente la posición actual de la cámara hacia la posición deseada
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavidad * Time.deltaTime);
    }
}
