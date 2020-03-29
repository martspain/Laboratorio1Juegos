using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{

    private float velocity = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Si se presiona la tecla "Z" se incrementa el tamaño del cubo
        if (Input.GetKey(KeyCode.Z))
            transform.localScale += Vector3.one * velocity * Time.deltaTime;

        // Si se presiona la tecla "X" se decrementa el tamaño del cubo
        if (Input.GetKey(KeyCode.X))
            transform.localScale -= Vector3.one * velocity * Time.deltaTime;
    }
}
