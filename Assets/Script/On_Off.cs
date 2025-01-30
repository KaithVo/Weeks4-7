using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class On_Off : MonoBehaviour
{
    public SpriteRenderer sr;
    public On_Off script;
    public GameObject go; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            go.SetActive(false); 
            //script.enabled = false; 
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true; 
            go.SetActive(true); 
            //script.enabled = true; 
        }
    }
}
