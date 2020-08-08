using UnityEngine;
using UnityEngine.EventSystems;

namespace Sweet_And_Salty_Studios
{
    public class UI_DragUIElementButton : UI_Button
    {
        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);

            ButtonEvent.Invoke();
        }

        public override void OnBeginDrag(PointerEventData eventData)
        {
            base.OnBeginDrag(eventData);

            ButtonEvent.Invoke();

        }

        public override void OnDrag(PointerEventData eventData)
        {
            base.OnDrag(eventData);
        }
    }
}