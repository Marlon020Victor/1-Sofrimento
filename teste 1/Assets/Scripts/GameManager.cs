using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI CMoedas,Vitoria,AddInfo;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria, clipDerrota;
    private AudioSource source;
    private void Awake()
    {   
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
       else
        {
            Destroy(gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        Inicializacao();
    }

    public void Inicializacao()
    {
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
        source.Stop();
        source.PlayOneShot(clipVitoria);
    }

    }
    
    // Update is called once per frame
   public  void GameOver()
    {
        source.PlayOneShot(clipDerrota);
    }
}
