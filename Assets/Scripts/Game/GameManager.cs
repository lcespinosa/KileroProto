using Environment;
using Input;
using UnityEngine;
using Utility;

namespace Game
{
    public class GameManager : Singleton<GameManager>
    {
        // Prevent non-singleton constructor use.
        protected GameManager()
        {
        }

        #region Properties

        private BallManager _ballManager;

        public BallManager BallManager
        {
            get
            {
                if (_ballManager == null)
                {
                    _ballManager = GameObject.FindWithTag("BallObject")?.GetComponent<BallManager>();
                }

                return _ballManager;
            }
        }
        
        private bool _paused;
        public bool Paused {
            get {
                // get paused
                return _paused;
            }
            set {
                // set paused 
                _paused = value;
                if (_paused) {
                    // pause time
                    Time.timeScale = 0f;
                } else {
                    // unpause Unity
                    Time.timeScale = 1f;
                }
            }
        }

        #endregion

        #region States

        private StateMachineBehaviour _stateMachine;

        public StateMachineBehaviour StateMachine
        {
            get
            {
                if (_stateMachine == null)
                {
                    _stateMachine = transform.GetComponentInChildren<StateMachineBehaviour>();
                }
                return _stateMachine;
            }
        }

        #endregion

        #region Controls

        private InputManager _input;
        public InputManager Input
        {
            get
            {
                if (_input == null)
                {
                    _input = transform.GetComponentInChildren<InputManager>();
                }
                return _input;
            }
        }

        #endregion
        
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
