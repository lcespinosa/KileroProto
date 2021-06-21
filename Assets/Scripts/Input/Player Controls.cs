// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""582d3e31-38a6-4a40-9e50-bb23f8cf7502"",
            ""actions"": [
                {
                    ""name"": ""TouchInput"",
                    ""type"": ""Value"",
                    ""id"": ""15994683-efe1-41aa-b865-62202c05a124"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPress"",
                    ""type"": ""Button"",
                    ""id"": ""9460774c-5fcf-4751-b08f-96954cb9a5e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9c5d491a-387c-404a-9bbe-9dccaae83412"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera_Move"",
                    ""type"": ""Value"",
                    ""id"": ""2bc60e24-d7b1-4a5f-b100-d7662a2f663d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e43cbbf7-3f0c-4b43-bd46-99e95fd726da"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3064f2c7-e9a5-47a7-a71f-1d394e561256"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f6c2e7e-7296-41f1-9638-09497fa1912f"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""5406d418-16c4-4978-af94-8a10955d5e27"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f5a6efa6-c3e6-42f4-b8ca-b0532e39ab65"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""209d9aae-9913-43b9-9c89-da69a624d38b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""973c924a-0953-43b1-bd39-887912c2f762"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f77b7cc5-9595-4ade-9e33-b3b729a883fb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""924602c2-a3aa-4c7b-a263-40afe71e9c95"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""62a34526-c4e9-4e0c-afce-2c3c46556483"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a1d5b25-7bac-4239-815c-7ae775dd2318"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""136df715-161b-40a9-8c7a-c9abe0ab590d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""12e4eb3a-fb83-4a6a-aa10-a2ff5ec4e667"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_TouchInput = m_Gameplay.FindAction("TouchInput", throwIfNotFound: true);
        m_Gameplay_TouchPress = m_Gameplay.FindAction("TouchPress", throwIfNotFound: true);
        m_Gameplay_TouchPosition = m_Gameplay.FindAction("TouchPosition", throwIfNotFound: true);
        m_Gameplay_Camera_Move = m_Gameplay.FindAction("Camera_Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_TouchInput;
    private readonly InputAction m_Gameplay_TouchPress;
    private readonly InputAction m_Gameplay_TouchPosition;
    private readonly InputAction m_Gameplay_Camera_Move;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInput => m_Wrapper.m_Gameplay_TouchInput;
        public InputAction @TouchPress => m_Wrapper.m_Gameplay_TouchPress;
        public InputAction @TouchPosition => m_Wrapper.m_Gameplay_TouchPosition;
        public InputAction @Camera_Move => m_Wrapper.m_Gameplay_Camera_Move;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @TouchInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchInput;
                @TouchInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchInput;
                @TouchInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchInput;
                @TouchPress.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPress;
                @TouchPress.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPress;
                @TouchPress.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPress;
                @TouchPosition.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTouchPosition;
                @Camera_Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCamera_Move;
                @Camera_Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCamera_Move;
                @Camera_Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCamera_Move;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchInput.started += instance.OnTouchInput;
                @TouchInput.performed += instance.OnTouchInput;
                @TouchInput.canceled += instance.OnTouchInput;
                @TouchPress.started += instance.OnTouchPress;
                @TouchPress.performed += instance.OnTouchPress;
                @TouchPress.canceled += instance.OnTouchPress;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @Camera_Move.started += instance.OnCamera_Move;
                @Camera_Move.performed += instance.OnCamera_Move;
                @Camera_Move.canceled += instance.OnCamera_Move;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouchPress(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnCamera_Move(InputAction.CallbackContext context);
    }
}
