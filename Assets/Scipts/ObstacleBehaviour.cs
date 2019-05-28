using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool enter = true;
    private SpriteRenderer ren;
    public int speed;
    private AudioSource gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = GetComponent<AudioSource>();
        ren = GetComponent<SpriteRenderer>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(speed, 0, 0), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "DestroyGO")
        {
            Destroy (gameObject);
        }

        if (col.gameObject.tag == "DestroyP")
        {
            gameOver.Play();
            Destroy (col.gameObject);
            Time.timeScale=0;
        }
    }

    void OnTriggerEnter2D(Collider2D strike)
    {
        if(strike.gameObject.tag == "DestroyGO")
        {
            Destroy (gameObject);
        }

        if (strike.gameObject.tag == "DestroyP")
        {
            SpriteRenderer player = strike.GetComponent<SpriteRenderer>();
            if (ren.color!=(player.color))
            {
                gameOver.Play();
                Destroy (strike.gameObject);
                Time.timeScale=0;
            }
            
        }
    }
}