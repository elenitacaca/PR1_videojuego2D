using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movpersonaje : MonoBehaviour
{

    public float multiplicadorVelocidad = 1;
    public float multiplicadorSalto = 1;
    Rigidbody2D rb;
    SpriteRenderer sr;

    public bool puedoSaltar = true;

    public void Respawnear(){
        Debug.Log("Vidas: "+GameManager.vidas);
        GameManager.vidas -=  1;
        Debug.Log("Vidas: "+GameManager.vidas);
        transform.position = respawn.transform.position;
    }
    GameObject respawn;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
        respawn = GameObject.Find("respawn");
        transform.position = respawn.transform.position;
    }
   
    // Update is called once per frame
    void Update()
    {
    if(GameManager.estoyMuerto) return;
        
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
     RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
     Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

     if(hit){
        puedoSaltar = true;
        Debug.Log(hit.collider.name);
     }else{ 
        puedoSaltar = false;
     }   
     
        //SALTO

     
     
     
        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar){
        
            rb.AddForce(
                new Vector2(0, multiplicadorSalto),
                 ForceMode2D.Impulse
            );
            Debug.Log("salto");

        }
       
        if(transform.position.y <= -7){
            Respawnear();
          }
         //0 vidas
          if(GameManager.vidas <= 0)
          {
            GameManager.estoyMuerto = true;
          }



    }
          



   
   
    
}
