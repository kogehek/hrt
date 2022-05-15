 using UnityEngine;
 using System.Collections;
 using System;
 using UnityEngine.Events;
 using UnityEngine.EventSystems;
 
 
public class EventButtonUnit : MonoBehaviour , IPointerClickHandler
{
    #region IPointerClickHandler implementation
    public void OnPointerClick (PointerEventData eventData)
    {
        EventTriggered(); 
    }
    #endregion

    [SerializeField]
    private Unit unit;
    [Serializable]
    public class ClickEvent : UnityEvent<Unit> {}
    [SerializeField]
    private ClickEvent clickEvent = new ClickEvent();
    public ClickEvent onClickEvent { get { return clickEvent; } set { clickEvent = value; } }
    public void EventTriggered()
    {
        onClickEvent.Invoke(unit);
    }
}