using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantasmaScript : MonoBehaviour
{

    Vector3 posicionInicial;
    GameObject personaje;
    public float velocidadFantasma = 10.0f;
    // Start is called before the first frame update
    AudioSource _audioSource;
    void Start()
    {
        posicionInicial = transform.position;
        //personaje = GameObject.Find("personaje");
        personaje = GameObject.FindGameObjectWithTag("Player");
        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, personaje.transform.position);
        float velocidadFinal = velocidadFantasma * Time.deltaTime;
        
        if(distancia <= 4.1f){
            

            //Debug.DrawLine(transform.position, personaje.transform.position, Color.red, 2.5f);
            transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position, velocidadFinal);
            _audioSource.Play();
            if(_audioSource.isPlaying == false){
                _audioSource.Play();
            }
        }else{
            
            transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal);

            //Debug.DrawLine(transform.position, personaje.transform.position, Color.white, 2.5f);
            
        }

        //Debug.Log(distancia);
        //Debug.Log(transform.position, personaje.transform.position, Color.white, 2.5f);
        
    }
}
