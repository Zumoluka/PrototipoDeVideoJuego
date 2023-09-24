using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 
    public Transform objetivo; // El objeto que la c�mara seguir�

    public float suavidad = 5.0f; // La suavidad del seguimiento, ajusta seg�n sea necesario

    private Vector3 offset; // Distancia inicial entre la c�mara y el objetivo

    void Start()
    {
        if (objetivo == null)
        {
            Debug.LogError("No se ha establecido un objetivo para la c�mara.");
            return;
        }

        offset = transform.position - objetivo.position;
    }

    void LateUpdate()
    {
        if (objetivo == null)
            return;

        // Calcula la posici�n deseada de la c�mara basada en la posici�n actual del objetivo y el offset inicial
        Vector3 posicionDeseada = objetivo.position + offset;

        // Interpola suavemente la posici�n actual de la c�mara hacia la posici�n deseada
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavidad * Time.deltaTime);
    }
}
