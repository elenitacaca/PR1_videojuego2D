using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchos : MonoBehaviour
{
    
    private GameObject personaje;

    private Movpersonaje movpersonaje;
    

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        movpersonaje = personaje.GetComponent<Movpersonaje>();
       // movpersonaje.Respawnear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
//esto sta mal
 void OnTriggerEnter2D(Collider2D col){

        if(col.name == "Personaje") 
        {
          AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDead);
          movpersonaje.Respawnear();
        } 
         
    }


}
