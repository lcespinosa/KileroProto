using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallImpulse : MonoBehaviour
{
    public float power = 1.0f;
    public Rigidbody rb;
    public Vector3 initialTouchPosition;
    public Vector3 finalTouchPosition;
    public float initialTime = 0.0f;
    public float finalTime = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(0,0, thrust, ForceMode.Impulse);
    }

    /*public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 dragVectorDirection = (eventData.position - eventData.pressPosition).normalized;
        GetDragDirection(dragVectorDirection);
    }
    
    private enum DraggedDirection
    {
        Up,
        Down,
        Right,
        Left
    }
    private DraggedDirection GetDragDirection(Vector3 dragVector)
    {
        float positiveX = Mathf.Abs(dragVector.x);
        float positiveY = Mathf.Abs(dragVector.y);
        DraggedDirection draggedDir;
        if (positiveX > positiveY)
        {
            draggedDir = (dragVector.x > 0) ? DraggedDirection.Right : DraggedDirection.Left;
        }
        else
        {
            draggedDir = (dragVector.y > 0) ? DraggedDirection.Up : DraggedDirection.Down;
        }
        Debug.Log(draggedDir);
        return draggedDir;
    }*/
    
    
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            
            if (touch.phase == TouchPhase.Began)
            {
                initialTouchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                initialTime = Time.time;
            }

            if (touch.phase == TouchPhase.Ended && touch.tapCount == 1)
            {
                finalTouchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                finalTime = Time.time;
                
                
                Vector3 direction = finalTouchPosition - initialTouchPosition;
                float duration = finalTime - initialTime;
                float distance = direction.magnitude;
                
                power = (distance / duration)*2;
                
                //rb.AddForceAtPosition(new Vector3(0,0,power),direction,ForceMode.Impulse);
                rb.AddForce(direction, ForceMode.Impulse);
                //rb.AddRelativeForce(direction, ForceMode.Impulse);                
            }
        }
    }
}
