using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projétil : MonoBehaviour
{
    public float speed;
    private int parede;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Parede")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);            
        }       
    }
}

