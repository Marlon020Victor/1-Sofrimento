using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI CMoedas,Vitoria,AddInfo;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;
    private AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);

        restantes = FindObjectsOfType<Moeda>().Length;

        CMoedas.text = $"Moedas restantes: {restantes}";
        Vitoria.text = " ";
        AddInfo.text = " ";
    }

    public void SubtrairMoedas(int valor){

    restantes -= valor ;
    CMoedas.text = $"Moedas restantes: {restantes}";
        source.PlayOneShot(clipMoeda);

        if (restantes == 0){

        Vitoria.text = "Parabéns";
        AddInfo.text = "Você coletou todas as moedas.";

    }

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
