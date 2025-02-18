using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    public float speed = 2f;
    public Transform newspaper; 

    private bool left = false; 
    private bool right = false;
    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = transform.position;
        //pos.x += speed * Time.deltaTime;

        //Vector2 screenPos = Camera.main.WorldToScreenPoint (pos);
        //if (screenPos.x<0)
        //{
        //    Vector3 fixedPos = new Vector3(0, 0, 0);
        //    pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
        //    speed = speed * -1;
        //}
        //if (screenPos.x > Screen.width)
        //{
        //    Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
        //    pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
        //    speed = speed * -1;
        //}
        //transform.position = pos;
        // finding this one that talked about transform https://discussions.unity.com/t/setting-a-variable-as-public-transform/607629/3

        if (left)
        
            newspaper.position += Vector3.left * speed * Time.deltaTime;

        if (right)

            newspaper.position += Vector3.right * speed * Time.deltaTime;
   
    }

  public void moveLeft()
    {
        left = true;
    }

    public void moveRight()
    {
        right = true;
    }
    //public void GoLeft (float s)
    //{
    //    speed = -s;
    //}

    //public void GoRight(float s)
    //{
    //    speed = s;
    //}
    //public void stop()
    //{
    //    speed = 0;
    //}
}
