﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
        }
<<<<<<< HEAD
<<<<<<< HEAD
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
        }
    }*/

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);

        }
||||||| 59e4ace... Success destroy enemy
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
=======
>>>>>>> parent of 59e4ace... Success destroy enemy
||||||| 59e4ace... Success destroy enemy
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "AllyCastle")
        {
            Destroy(this.gameObject);
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
=======
>>>>>>> parent of 59e4ace... Success destroy enemy
    }
}
