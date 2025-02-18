using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public float speed = 2f;
  

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint (pos);

    }
    public float s;
    public void goLeft ()
    {
        speed = s;
    }

    public void goRight()
    {
        speed = -s; 
    }
}
