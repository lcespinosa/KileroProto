using System;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

namespace Input
{
    public class InputManager : MonoBehaviour
    {

        #region Events

        public delegate void StartTouchEvent(Vector2 screenPosition, float time);

        public event StartTouchEvent OnStartTouch;
        
        public delegate void EndTouchEvent(Vector2 screenPosition, float time);

        public event EndTouchEvent OnEndTouch;

        #endregion

        #region Properties
        
        private Camera _camera;

        #endregion
        
        private void Awake()
        {
            EnhancedTouchSupport.Enable();
            _camera = Camera.main;
        }

        private void LateUpdate()
        {
            if (Touch.activeFingers.Count == 1) //Un solo dedo toco la pantalla
            {
                Touch activeTouch = Touch.activeFingers[0].currentTouch;
                //Debug.Log($"Phase: {activeTouch.phase} | Position: {activeTouch.startScreenPosition}");
                switch (activeTouch.phase)
                {
                    case TouchPhase.Began:
                        if (OnStartTouch != null)
                        {
                            OnStartTouch(activeTouch.startScreenPosition, (float)activeTouch.startTime);
                        }
                        break;
                    case TouchPhase.Canceled:
                    case TouchPhase.Ended:
                        if (OnEndTouch != null)
                        {
                            OnEndTouch(activeTouch.screenPosition, (float)activeTouch.time);
                        }
                        break;
                }
            }
        }
        
        
        /*
        private PlayerControls _playerControls;
        
        private void Awake()
        {
            _playerControls = new PlayerControls();
        }

        private void OnEnable()
        {
            _playerControls.Enable();

            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerDown += FingerDown;
        }

        private void OnDisable()
        {
            _playerControls.Disable();

            UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerDown -= FingerDown;
        }

        private void Start()
        {
            _playerControls.Gameplay.TouchPress.started += context => StartTouch(context);
            _playerControls.Gameplay.TouchPress.canceled += context => EndTouch(context);
        }

        private void StartTouch(InputAction.CallbackContext context)
        {
            if (OnStartTouch != null)
            {
                Vector2 position = _playerControls.Gameplay.TouchPosition.ReadValue<Vector2>();
                Debug.Log("OnStartTouch " + position);
                OnStartTouch(position, (float) context.startTime);
            }
        }

        private void EndTouch(InputAction.CallbackContext context)
        {
            if (OnEndTouch != null)
            {
                Vector2 position = _playerControls.Gameplay.TouchPosition.ReadValue<Vector2>();
                Debug.Log("OnEndTouch " + position);
                OnEndTouch(position, (float) context.time);
            }
        }

        private void FingerDown(Finger finger)
        {
            Vector2 position = finger.screenPosition;
            Debug.Log("OnFingerDown " + position);
            if (OnStartTouch != null)
            {
                OnStartTouch(position, Time.time);
            }
        }*/
    }
}
