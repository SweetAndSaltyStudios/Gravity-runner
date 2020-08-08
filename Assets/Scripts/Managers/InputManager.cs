using UnityEngine;
using UnityEngine.EventSystems;

namespace Sweet_And_Salty_Studios
{
    public class InputManager : Singelton<InputManager>
    {
        private const float MIN_SWIPE_DISTANCE = 10f;

        private Vector2 startTouchPosition;
        private Vector2 endTouchPosition;
        private Vector2Int swipeDirection;      

        public bool GetMouseButtonDown(int index)
        {
            if(Input.GetMouseButtonDown(index))
            {
                startTouchPosition = Input.mousePosition;

                return true;
            }

            return false;
        }

        public bool GetMouseButtonUp(int index)
        {
            if(Input.GetMouseButtonUp(index))
            {
                endTouchPosition = Input.mousePosition;

                VarifySwipe();

                return true;
            }

            swipeDirection = Vector2Int.zero;
            return false;
        }

        private bool SwipeDistanceCheck()
        {
            return VerticalSwipeDistance() > MIN_SWIPE_DISTANCE || HorizontalSwipeDistance() > MIN_SWIPE_DISTANCE;
        }

        private bool IsVerticalSwipe()
        {
            return VerticalSwipeDistance() > HorizontalSwipeDistance();
        }

        private float HorizontalSwipeDistance()
        {
            return Mathf.Abs(startTouchPosition.x - endTouchPosition.x);
        }

        private float VerticalSwipeDistance()
        {
            return Mathf.Abs(startTouchPosition.y - endTouchPosition.y);
        }

        private void VarifySwipe()
        {
            if(SwipeDistanceCheck())
            {
                if(IsVerticalSwipe())
                {
                    if(startTouchPosition.y - endTouchPosition.y > 0)
                    {
                        swipeDirection = new Vector2Int(0, -1);
                    }
                    else
                    {
                        swipeDirection = new Vector2Int(0, 1);
                    }
                }
                else
                {
                    if(startTouchPosition.x - endTouchPosition.x > 0)
                    {

                        swipeDirection = new Vector2Int(-1, 0);
                    }
                    else
                    {
                        swipeDirection = new Vector2Int(1, 0);
                    }
                }
            }
        }

        private void Awake()
        {
            Physics2D.gravity = swipeDirection;
        }

        private void Update()
        {
            if(GetMouseButtonDown(0))
            {

            }

            if(GetMouseButtonUp(0))
            {
                Physics2D.gravity = swipeDirection;
            }
        }
    }
}