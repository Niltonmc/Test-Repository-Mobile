using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonControl : MonoBehaviour, IPointerUpHandler, IPointerDownHandler{
    
    public bool isPressed;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void OnPointerUp(PointerEventData eventData){
        isPressed = false;
    }

    public void OnPointerDown(PointerEventData eventData){
        isPressed = true;
    }
}
