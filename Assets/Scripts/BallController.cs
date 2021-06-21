using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallController : MonoBehaviour
{
    public float power = 1.0f;
    public float powerModificator = 1.0f;
    public Rigidbody rb;
    public Vector3 initialTouchPosition;
    public Vector3 finalTouchPosition;
    public float initialTime = 0.0f;
    public float finalTime = 0.0f;
    public float duration;
    public float distance;
    public float rbVelocity = 0.0f;

    //public LineRenderer lineR;
    

    // Start is called before the first frame update
    void Start()
    {
        /*lineR = GetComponent<LineRenderer>();
        lineR.startWidth = 0.2f;
        lineR.endWidth = 0.1f;
        Vector3[] positions = new Vector3[2]
        {
            new Vector3(0,0,0),
            new Vector3(0,0,0)
            
            //initialTouchPosition,
            //finalTouchPosition
        };
        lineR.positionCount = 2;*/
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(0,0, thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            rbVelocity = rb.velocity.z;
            Touch touch = Input.GetTouch(i);
            
            if (touch.phase == TouchPhase.Began)
            {
                initialTouchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                initialTime = Time.time;
                //lineR.SetPosition(0, initialTouchPosition);
            }

            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                finalTouchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                //lineR.SetPosition(1, finalTouchPosition);
                finalTime = Time.time;
                
                
                Vector3 direction = finalTouchPosition - initialTouchPosition;
                duration = finalTime - initialTime;
                distance = direction.magnitude;
                
                power = (distance / duration) * powerModificator;
                Vector3 finalDirection = new Vector3(direction.x * power, direction.y * power, direction.z * power);
                
                //rb.AddForceAtPosition(new Vector3(0,0,power),direction,ForceMode.Impulse);
                rb.AddForce(finalDirection, ForceMode.Impulse);
                //rb.AddRelativeForce(direction, ForceMode.Impulse);            
                
                direction = Vector3.zero;
                duration = 0.0f;
            }
        }
    }
}
