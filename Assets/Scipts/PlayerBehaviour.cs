using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    private Rigidbody2D rb;
    private SpriteRenderer ren;
    public Score controlShifter;
    // Start is called before the first frame update
    void Start () {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D> ();
        ren = GetComponent<SpriteRenderer> ();
    }

    // Update is called once per frame
    void Update () {
        if (controlShifter.GetScore () > 30 && controlShifter.GetScore () < 39) {
            rb.gravityScale = -10;
        } else if (controlShifter.GetScore () > 10 && controlShifter.GetScore () < 19) {
            rb.gravityScale = -10;
        } else {
            rb.gravityScale = +10;
        }

        if (Input.GetKeyDown (KeyCode.Space)) {
            if (controlShifter.GetScore () > 30 && controlShifter.GetScore () < 39) {
                rb.AddForce (new Vector3 (0, -175, 0), ForceMode2D.Impulse);
            } else if (controlShifter.GetScore () > 10 && controlShifter.GetScore () < 19) {
                rb.AddForce (new Vector3 (0, -175, 0), ForceMode2D.Impulse);
            } else {
                rb.AddForce (new Vector3 (0, 175, 0), ForceMode2D.Impulse);
            }
            ren.color = new Color (0.3203987f, 0.5408221f, 0.9056604f);
        }

        if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            if (controlShifter.GetScore () < Random.Range (22, 27)) {
                ren.color = Color.black;
            } else {
                ren.color = Color.white;
            }
        }

        if (Input.GetKeyDown (KeyCode.RightArrow)) {
            if (controlShifter.GetScore () < Random.Range (22, 27)) {
                ren.color = Color.white;
            } else {
                ren.color = Color.black;
            }
        }

        if (Input.touchCount == 1) {
            Touch touch = Input.GetTouch (0);
            if (touch.phase == TouchPhase.Began) {
                if (touch.position.x > (Screen.width / 2)) {
                    if(ren.color == Color.black){
                        ren.color = Color.white;
                    }else{
                        ren.color = Color.black;
                    }
                } else {
                    if (controlShifter.GetScore () > 30 && controlShifter.GetScore () < 39) {
                        rb.AddForce (new Vector3 (0, -50, 0), ForceMode2D.Impulse);
                    } else if (controlShifter.GetScore () > 10 && controlShifter.GetScore () < 19) {
                        rb.AddForce (new Vector3 (0, -50, 0), ForceMode2D.Impulse);
                    } else {
                        rb.AddForce (new Vector3 (0, 50, 0), ForceMode2D.Impulse);
                    }
                    ren.color = new Color (0.3203987f, 0.5408221f, 0.9056604f);
                }
            }
        }
    }
}