using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingLine : MonoBehaviour
{
    public LineRenderer line;
    
    // Start is called before the first frame update
    void Start()
    {
        //Material mat = new Material(Shader.Find("Unlit/Color"));
        //mat.color = Color.yellow;
        //line.materials[0] = mat;
        line = GetComponent<LineRenderer>();
        line.startWidth = 0.2f;
        line.endWidth = 0.2f;

        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            line.positionCount = 2;

            if (touch.phase == TouchPhase.Began)
            {
                line.SetPosition(0, Camera.main.ScreenToWorldPoint(touch.position));
            }

            if (touch.phase == TouchPhase.Moved && touch.tapCount == 1)
            {
                line.SetPosition(1, Camera.main.ScreenToWorldPoint(touch.position));
            }
        }
    }
}
