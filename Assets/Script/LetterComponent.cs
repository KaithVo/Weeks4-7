using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           // GameObject newThing = Instantiate(prefab, mouse, Quaternion.identity);

           // newThing.transform.localScale = Vector3.one * Random.Range(0.75f, 1.5f);
           



        }
        
    }
}
