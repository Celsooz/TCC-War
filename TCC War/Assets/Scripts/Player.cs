using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rbPlayer;

    [Header("Movimento")]
    public float speed = 1;

    [Header("Pulo")] 
    public float forceJump;
    public Transform sensor;
    public LayerMask chão;
    public int pulosextras;
    public bool taNoChao;

    [Header ("Coletável")]
    public int coins;

    [Header("Tiro")]
    public GameObject projetil;
    public GameObject pontoDeTiro; 


    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        taNoChao = Physics2D.OverlapCircle(sensor.position, 0.2f, chão);

        float movimentoHorizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * movimentoHorizontal);

        if (Input.GetButtonDown("Jump") && taNoChao == true)
        {
            rbPlayer.AddForce(new Vector2(0, forceJump), ForceMode2D.Impulse);
            pulosextras--;

        }

        if (taNoChao)
        {
            pulosextras = 0;
        }

        

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projetil, pontoDeTiro.transform.position, projetil.transform.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coins")
        {
            Destroy(collision.gameObject);
            coins = coins + 1;
        }
    }
}
        
    

    



