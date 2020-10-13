using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{

    float rotationOnX;
    float mouseSens = 90;
    Transform trPlayer;


    // Start is called before the first frame update
    void Start()
    {
        trPlayer = transform.parent;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSens;
        float m_X = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSens;

        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX, -90, 90);
        transform.localEulerAngles = new Vector3(rotationOnX, 0, 0);

        trPlayer.Rotate(Vector3.up * m_X);
    }
}
