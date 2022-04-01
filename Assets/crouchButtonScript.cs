using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class crouchButtonScript : MonoBehaviour,IPointerDownHandler,IPointerUpHandler 
{

    public bool isPressing;
public void OnPointerDown(PointerEventData eventData)
{
    isPressing = true;
}
public void OnPointerUp(PointerEventData eventData)
{
    isPressing = false;
}
}
