using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour

{

    public float speed;
    public GameObject player;
    public float distance;
    [SerializeField] GameObject projetil;
    public GameObject pontoDeTiro;
    public float distancia2;

    private bool isFlipped;

    float tempoDeAtaque;

    void Start()
    {

    }

    void Update()    
    {
        distance = Vector2.Distance(player.transform.position, transform.position);
        distancia2 = transform.position.x - player.transform.position.x;

        if (distancia2 < 0 && !isFlipped)
        {
            Flip();
        }
        else if (distancia2 > 0 && isFlipped)
        {
            Flip();
        }

        if (tempoDeAtaque <= Time.time && distance<=1)
        {
            Atacar();
        }
         
        if (distance <= 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    void Atacar()
    {
        Instantiate(projetil, pontoDeTiro.transform.position, projetil.transform.rotation);
        tempoDeAtaque = Time.time + 2;            
    }

    void Flip()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        isFlipped = !isFlipped;
    }
}

