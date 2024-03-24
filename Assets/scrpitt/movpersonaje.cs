using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movpersonaje : MonoBehaviour
{

    public float multiplicadorVelocidad = 1;
    public float multiplicadorSalto = 1;
    Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO 
        float mov = Input.GetAxis("Horizontal") * multiplicadorVelocidad * Time.deltaTime;

        //transform.position = new Vector3(transform.position.x+mov, transform.position.y,transform.position.z ); }
        transform.Translate(mov, 0, 0);
        if (Input.GetKeyDown(KeyCode.A))
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            sr.flipX = false;
        }

        //SALTO

     RaycastHit2D hit;
     hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
     if(hit){
     Debug.DrawRay(transform.position, Vector2.down, Color.magenta);
     
     }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
            Debug.Log("salto");

        }
    }

}