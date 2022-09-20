using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour

{
    private bool isActive = true;


    void Start()
    {
        
    }

    
    void Update()
    {
       
        if (isActive)
        {
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);
                if (screenTouch.phase == TouchPhase.Moved)
                {
                   gameObject.transform.Rotate(0f, screenTouch.deltaPosition.x * 0.01f , 0f);
                }

                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = true;
                }
            }
        }

    }
}
