using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuuMouseTouchMove : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 characterScale = transform.localScale;

            if (mousePos.x > 1)
            {
                //move right
                transform.Translate(moveSpeed, 0, 0);
                characterScale.x = 1;
            }
            else if (mousePos.x < -1)
            {
                // move left
                transform.Translate(-moveSpeed, 0, 0);
                characterScale.x = -1;
            }
            transform.localScale = characterScale;
        }
    }
}
