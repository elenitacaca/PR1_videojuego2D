using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuego : MonoBehaviour
{
    GameObject personaje;
    bool bolaDerecha = true;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        bolaDerecha = personaje.GetComponent<Movpersonaje>().miraDerecha;
    }

    // Update is called once per frame
    void Update()
    {
        if(bolaDerecha){
            transform.Translate(0.01f, 0, 0);
        }else{
            transform.Translate(-0.01f, 0, 0);
        }
        
    }
}
