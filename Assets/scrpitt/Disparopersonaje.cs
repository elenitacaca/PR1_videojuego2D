using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparopersonaje : MonoBehaviour
{

    public GameObject fuego;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){

            Instantiate(fuego, transform.position, Quaternion.identity);

        }
        
    }
}
