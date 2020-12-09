using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ScrollableButton : Button {

    // TODO: develop if EventSystem's threshold is not enough;

    public override void OnPointerClick(PointerEventData eventData) { }

    public override void OnPointerUp(PointerEventData eventData) { }

    public override void OnPointerExit(PointerEventData eventData) {
//#if !UNITY_EDITOR
        //base.OnPointerExit(eventData);
        //if (!eventData.dragging)
        //    base.OnPointerClick(eventData);

        //EventSystem es;
        //es.IsPointerOverGameObject
//#endif
    }

}