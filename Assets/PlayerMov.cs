using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    float velocity = 5;
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rigid.velocity = transform.right * -velocity;
        else if (Input.GetKey(KeyCode.D))
            rigid.velocity = transform.right * velocity;
        else if (Input.GetKey(KeyCode.W))
            rigid.velocity = transform.forward * velocity;
        else if (Input.GetKey(KeyCode.S))
            rigid.velocity = transform.forward * -velocity;
        else
            rigid.velocity = Vector3.zero;
    }
}
