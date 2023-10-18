using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI CMoedas,Vitoria,AddInfo;
    public int restantes; 
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
