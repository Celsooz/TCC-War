using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RondaInimigo : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
}
