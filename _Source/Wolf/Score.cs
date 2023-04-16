using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {

        for (int i = 0; i < 3; i++)
            if (collision.collider.CompareTag("Wolf"))
            {
                Destroy(collision.gameObject);
                Debug.Log("Wolfs destroyed " + i);
            }

    }

}