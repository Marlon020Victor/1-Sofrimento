using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int ForcaPulo = 5 ;
    public bool noChao ;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

     void OnCollisionEnter(Collision col)
     {
       if (col.gameObject.tag == "chão")
       {
        noChao = true;
       }
     }
    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(inputHorizontal,0,inputVertical)* velocidade );


        if (transform.position.y <= -10 ) {
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao){
            rb.AddForce(Vector3.up * ForcaPulo, ForceMode.Impulse);
            noChao = false ;
        }
    }
}