using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour{
    public float speed;
    public float direction;
    public ButtonControl leftButtonMovement;
    public ButtonControl rightButtonMovement;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        transform.position = new Vector2(transform.position.x + speed* direction * Time.deltaTime,
        transform.position.y);
        if(leftButtonMovement.isPressed == true){
            direction = -1;
        }
        if(rightButtonMovement.isPressed == true){
            direction = 1;
        }
        if(leftButtonMovement.isPressed == false && rightButtonMovement.isPressed == false){
            direction = 0;
        }
    }
    public void MoveLeft(){
        direction = -1;
    }
    public void MoveRight(){
        direction = 1;
    }
}
