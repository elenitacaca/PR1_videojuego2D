using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas= 3;
    public static int puntos = 0;
    public static int muertes = 0;
    public static bool estoyMuerto = false;

    GameObject vidaText;

    // Start is called before the first frame update
    void Start()
    {
        vidaText = GameObject.Find("vidaText");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Puntos:" +puntos);
        Debug.Log("Dead:" +muertes);

        vidaText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();
    }
}
