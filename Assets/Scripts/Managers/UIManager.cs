using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace Sweet_And_Salty_Studios
{
    public class UIManager : Singelton<UIManager>
    {
        #region VARIABLES

        private readonly Canvas HUDCanvas;

        #endregion

        #region PROPERTIES

        #endregion PROPERTIES

        #region UNITY_FUNCTIONS

        private void Awake()
        {
            Initialize();
        }

        #endregion UNITY_FUNCTIONS

        #region CUSTOM_FUNCTIONS

        private void Initialize()
        {
           
        }

        public void ActivateDragLine(bool isActive = false, Vector2 startPosition = new Vector2(), Vector2 endPosition = new Vector2())
        {
           
        }

        public void UpdateDragLine(Vector2 startPosition, Vector3 endPosition)
        {
              
        }

        public void ExitButton()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }   

        #endregion CUSTOM_FUNCTIONS
    }
}
