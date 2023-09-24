using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public GameObject player; // El objeto del jugador
    public GameObject camera; // La cámara que sigue al jugador

    void Update()
    {
        Vector3 direction = player.transform.position - camera.transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);

        // Asegúrate de que la rotación solo sea en el eje y
        rotation.x = 0;
        rotation.z = 0;

        player.transform.rotation = Quaternion.Lerp(player.transform.rotation, rotation, Time.deltaTime);
    }


    /*public int Speed = 0;
    public CharacterController controller;
    public float turnsmoothTime = 0.1f;
    float turnsmoothVelocity;
    public Transform cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        
        Vector3 direction = new Vector3(horizontal, 1, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Deg2Rad+ cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnsmoothVelocity, turnsmoothTime);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * Speed * Time.deltaTime);
        }
    }*/
}
