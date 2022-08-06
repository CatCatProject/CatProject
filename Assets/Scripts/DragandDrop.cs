using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragandDrop: MonoBehaviour
{
    private Vector2 startTouchPos;
    private Vector2 endTouchPos;
    private Touch touch;
    private void Update()
    {
        if(Input.touchCount == 1)
        {
            touch = Input.GetTouch(0);
            if(Camera.main.ScreenToWorldPoint(touch.position) == transform.position)
            {
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        {
                            startTouchPos = Input.GetTouch(0).position;
                            Debug.Log("Touch Start");
                            break;
                        }
                    case TouchPhase.Moved:
                        {
                            break;
                        }
                    case TouchPhase.Ended:
                        {
                            endTouchPos = Input.GetTouch(0).position;
                            Debug.Log("Touch End");
                            break;
                        }
                }
            }
        }
    }
}
