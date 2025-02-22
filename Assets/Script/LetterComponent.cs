using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterComponent : MonoBehaviour
{//call out the prefab to assign 
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //mouise position in screen coordinated
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //create newthing/ new prefab whenever the mouse clicked
            //Quaterion mean non rotation?
           GameObject newThing =  Instantiate(prefab, mouse, Quaternion.identity);

            newThing.transform.localScale = Vector3.one * Random.Range(0.5f, 1f);
            //Called MoveUp script in the GetComponent
            MoveUp myScript = newThing.GetComponent<MoveUp>();
            //destroy the new prefab after 5s
            Destroy(newThing, 5); 


        }
        
    }
}
