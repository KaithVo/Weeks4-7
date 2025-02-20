using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ZoomInOut : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    //saw this video when he is talking about using slider to modifying the text on slider
    //https://www.google.com/search?sca_esv=aa712384d2effb8a&rlz=1C5CHFA_enCA1026CA1026&sxsrf=AHTn8zqigJaBbnXuLbjNOCw9fnjJWthYMA:1740043515676&q=public+Slider+unity&source=lnms&fbs=ABzOT_DRhdiV9dRCo4XT1YwNJJyK2f7WKgxVpBwHmBeR6d4BGzhPgC-HW69KpCN43TklrKrwU3pgtKTsNwYX3VqOcX23h6kuxbJvbVP_LZRT1FgzypNc8MbMvgZhjkLSMTdhiBbUv1c9PPIz7hdI3n5JthPsMM5PsAK-nMPOR54Xvpc_U2EXPCem3E7UR2YS47I13phbem0foSuD9j2iiMClVadosTZQvA&sa=X&ved=2ahUKEwjG8ZSd99GLAxXsm4kEHTiGBOwQ0pQJegQIDxAB&biw=1011&bih=933&dpr=1#fpstate=ive&vld=cid:ad9669a0,vid:nTLgzvklgU8,st:0
    //As I uunderstand the unityengine.ui need to be there so that
    //I cann use the "Slider" which is related to the value I need to change
    public Slider zoomSlider;
 
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Slider;
  
        transform.localScale = Vector2.one * curve.Evaluate(t);
  
    }
}
