using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class DragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    void Start()
    {
        Debug.Log("Start DragObject class !");
    }

    public void OnBeginDrag(PointerEventData _EventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData _EventData)
    {
        Debug.Log("OnDrag");

    }

    public void OnEndDrag(PointerEventData _EventData)
    {
        Debug.Log("OnEndDrag");
    }
}
