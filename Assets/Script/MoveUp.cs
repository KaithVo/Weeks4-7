using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;

    public AnimationCurve curve;
    [Range (0,1)]
    public float t; 

 float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
       if(sprites.Length == 0)
        {

        }
        else
        {
            spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length)];
            spriteRenderer.sortingOrder = -1; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
        }
        transform. localScale = Vector2.one * curve.Evaluate(t);

        Vector3 pos = transform.position;
        pos.y += speed;
        transform.position = pos; 
    }
}
