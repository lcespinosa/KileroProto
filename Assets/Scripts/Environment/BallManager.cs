using System;
using Game;
using Input;
using UnityEngine;
using UnityEngine.Serialization;
using Utility;

namespace Environment
{
    public class BallManager : MonoBehaviour
    {

        #region Properties

        private Camera _camera;
        private GameManager _gameManager;
        private InputManager _inputManager;
        
        private Rigidbody _rigidbody;

        private bool _isTouching;
        private Vector3 _startTouchPosition;
        private float _startTouchTime;
        private Vector3 _endTouchPosition;
        private float _endTouchTime;

        #endregion

        private void Awake()
        {
            _camera = Camera.main;
            _gameManager = GameManager.Instance;
            _inputManager = _gameManager.Input;

            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            _inputManager.OnStartTouch += SetStartTouch;
            _inputManager.OnEndTouch += EndStartTouch;
        }

        private void OnDisable()
        {
            _inputManager.OnStartTouch -= SetStartTouch;
            _inputManager.OnEndTouch -= EndStartTouch;
        }

        #region Listeners

        private void SetStartTouch(Vector2 screenPosition, float time)
        {
            if (!_isTouching && IsObjectUnderTouch(screenPosition))
            {
                _isTouching = true;
                _startTouchPosition = new Vector3(screenPosition.y * -1, 0, screenPosition.x);
                _startTouchTime = time;
            }
        }
        
        private void EndStartTouch(Vector2 screenPosition, float time)
        {
            if (_isTouching)
            {
                _endTouchPosition = new Vector3(screenPosition.y * -1, 0, screenPosition.x);
                _endTouchTime = time;
                Move();
            }

            _isTouching = false;
        }
        
        #endregion

        private bool IsObjectUnderTouch(Vector2 touchPosition)
        {
            var ray = _camera.ScreenPointToRay(touchPosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                var rigidbody = raycastHit.collider.GetComponent<Rigidbody>();
                return (rigidbody != null && rigidbody.gameObject.CompareTag("BallObject"));
            }

            return false;
        }

        private void Move()
        {
            Vector3 direction = _endTouchPosition - _startTouchPosition;
            float duration = _endTouchTime - _startTouchTime;
            float distance = direction.magnitude;
            Vector3 velocity = direction.normalized * (distance / duration);
            PhysicsHelper.ApplyForceToReachVelocity(_rigidbody, velocity, 1, ForceMode.Acceleration);
        }
    }
}
