using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animação : MonoBehaviour
{
    private float rotacionar = 100;
    private Animator animacao; 
    private float segredo = 0;

    void Start()
    {
        animacao = GetComponent<Animator>();
    }

    void Update()
    {
        segredo = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift)) {
            segredo = 4;
        }

        if(segredo > 3 && Input.GetKey(KeyCode.Space)) {
            segredo = 5;
        }
        
        animacao.SetFloat("Andar", segredo);
        this.transform.Rotate(0, (Input.GetAxis("Horizontal") * rotacionar) * Time.deltaTime, 0);
    }
}
