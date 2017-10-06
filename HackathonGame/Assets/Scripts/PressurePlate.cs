using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    bool isPressed = false;
    float originalY = 0;
    float originalX = 0;

    float reducedY;

    public Box box;

    void Awake()
    {
        originalY = transform.localScale.y;
        originalX = transform.localScale.x;

        reducedY = originalY - .2f;
    }

    private void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D coll) {
     
        if (isPressed == false && transform.localScale.y != reducedY)
        {
            isPressed = true;
            transform.localScale = new Vector3(originalX, reducedY, 1);
            box.moveBoxLeft();
        }
    }

 
   
      
}
