using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moneda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//romper monedas cuando el pj las toque
     void OnTriggerEnter2D(Collider2D col){
         Debug.Log(col.gameObject.name);

         if(col.gameObject.name == "Personaje"){
            GameManager.puntos += 1;
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxCoin);
            Destroy(this.gameObject);
        }

    }


 }
