using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
   
    public float rangodeAlerta;
    public LayerMask CapadelJugador;
    bool estarAlerta;
    public Transform Jugador;
    public float velocidad;
    void Start()
    {
    
    }
    
    // Update is called once per frame
    void Update()
    {
        
       estarAlerta = Physics.CheckSphere(transform.position, rangodeAlerta, CapadelJugador);
        if(estarAlerta == true){
            //transform.LookAt(Jugador);
            transform.LookAt(new Vector3(Jugador.position.x, transform.position.y, Jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(Jugador.position.x, transform.position.y, Jugador.position.z), velocidad * Time.deltaTime);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangodeAlerta);
    }
}
