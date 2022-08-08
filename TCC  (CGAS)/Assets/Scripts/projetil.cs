using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    public float speed;
    private GameObject enemy;
    int valorFlip = 1;

    void Start()
    {
        enemy = GameObject.Find("Inimigo");
        
        if (enemy.transform.localScale.x >= 0)
        {
            valorFlip = 1;
        }
        else
        {
            valorFlip = -1;
        }
    }
    
    void Update()
    {        
        

        transform.Translate(Vector2.left * valorFlip * speed * Time.deltaTime);

        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
