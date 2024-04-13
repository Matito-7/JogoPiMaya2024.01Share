using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;


public class TankControl : MonoBehaviour
{
    public Transform a; //Ponto A para onde o Tank deve ir
    public float speed;

    //private bool playercollide = false;

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        playercollide = true;
    //    }
    //}

    private void Update()
    {
        //Mover o Tank para o ponto a
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, a.position, step);

        //Verificar se chegou ao ponto a
        if (transform.position == a.position)
        {
            //Destruir o Tank
            Destroy(this.gameObject);
        }

        //if (playercollide)
        //{
        //    // Mover o Tank para o ponto a
        //    float step = speed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, a.position, step);

        //    // Verificar se chegou ao ponto a
        //    if (transform.position == a.position)
        //    {
        //        // Destruir o Tank
        //        Destroy(gameObject);
        //    }
        //}
    }
}
