using UnityEngine;
using UnityEngine.EventSystems;

namespace Sweet_And_Salty_Studios
{
    public class UI_ItemButton : UI_Button
    {
        public override void OnBeginDrag(PointerEventData eventData)
        {
            base.OnBeginDrag(eventData);

            if (ButtonEvent != null)
            {
                ButtonEvent.Invoke();
            }
        }
    }
}