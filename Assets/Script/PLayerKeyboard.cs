using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerKeyboard : MonoBehaviour
{

    public float speed = 1;
    public float rotationSpeed = 50; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
        transform.Translate(0, Input.GetAxisRaw("Vertical") * 50 * Time.deltaTime, 0);
    }
}
