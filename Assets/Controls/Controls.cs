// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""f9f5c242-1a64-4463-8d4c-da342a85359e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""29cc794b-3815-4627-b1c5-d43d38378bfe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slow"",
                    ""type"": ""PassThrough"",
                    ""id"": ""448adaa7-66f9-415a-8c49-e5015ecd29a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a93b26c4-7f83-4a8e-8211-8a3ffe514c5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FastForward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""98535b43-3801-4e9e-b88c-5021de35b5eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b3a727a3-1d69-4474-9e91-39fc05e2ed62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftDPad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""07b9de54-e9ee-4ed1-9feb-51e73bc7a73d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap,Press""
                },
                {
                    ""name"": ""RightDPad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aa754b1d-88e3-48c0-b786-c06e5d5db357"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap,Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e2e484b5-7631-4590-be36-15b92831d6ac"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""734acb6b-cecd-4031-be45-822f1e830654"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53c8ea34-56ab-4e56-8f3d-51419d862f37"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47618241-d15b-434f-bfc4-fe0bf3803193"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85288be9-77b6-4f9b-8118-fccabc19d0a2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7682edc7-a145-4e5c-9518-8840eb5b6ffc"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftDPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98a83ca5-2c16-47f6-80bc-5c567979a497"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightDPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Move = m_GamePlay.FindAction("Move", throwIfNotFound: true);
        m_GamePlay_Slow = m_GamePlay.FindAction("Slow", throwIfNotFound: true);
        m_GamePlay_Pause = m_GamePlay.FindAction("Pause", throwIfNotFound: true);
        m_GamePlay_FastForward = m_GamePlay.FindAction("FastForward", throwIfNotFound: true);
        m_GamePlay_Grab = m_GamePlay.FindAction("Grab", throwIfNotFound: true);
        m_GamePlay_LeftDPad = m_GamePlay.FindAction("LeftDPad", throwIfNotFound: true);
        m_GamePlay_RightDPad = m_GamePlay.FindAction("RightDPad", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Move;
    private readonly InputAction m_GamePlay_Slow;
    private readonly InputAction m_GamePlay_Pause;
    private readonly InputAction m_GamePlay_FastForward;
    private readonly InputAction m_GamePlay_Grab;
    private readonly InputAction m_GamePlay_LeftDPad;
    private readonly InputAction m_GamePlay_RightDPad;
    public struct GamePlayActions
    {
        private @Controls m_Wrapper;
        public GamePlayActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GamePlay_Move;
        public InputAction @Slow => m_Wrapper.m_GamePlay_Slow;
        public InputAction @Pause => m_Wrapper.m_GamePlay_Pause;
        public InputAction @FastForward => m_Wrapper.m_GamePlay_FastForward;
        public InputAction @Grab => m_Wrapper.m_GamePlay_Grab;
        public InputAction @LeftDPad => m_Wrapper.m_GamePlay_LeftDPad;
        public InputAction @RightDPad => m_Wrapper.m_GamePlay_RightDPad;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Slow.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSlow;
                @Slow.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSlow;
                @Slow.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnSlow;
                @Pause.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnPause;
                @FastForward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFastForward;
                @FastForward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFastForward;
                @FastForward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFastForward;
                @Grab.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnGrab;
                @LeftDPad.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftDPad;
                @LeftDPad.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftDPad;
                @LeftDPad.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftDPad;
                @RightDPad.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightDPad;
                @RightDPad.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightDPad;
                @RightDPad.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightDPad;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Slow.started += instance.OnSlow;
                @Slow.performed += instance.OnSlow;
                @Slow.canceled += instance.OnSlow;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @FastForward.started += instance.OnFastForward;
                @FastForward.performed += instance.OnFastForward;
                @FastForward.canceled += instance.OnFastForward;
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
                @LeftDPad.started += instance.OnLeftDPad;
                @LeftDPad.performed += instance.OnLeftDPad;
                @LeftDPad.canceled += instance.OnLeftDPad;
                @RightDPad.started += instance.OnRightDPad;
                @RightDPad.performed += instance.OnRightDPad;
                @RightDPad.canceled += instance.OnRightDPad;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSlow(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnFastForward(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnLeftDPad(InputAction.CallbackContext context);
        void OnRightDPad(InputAction.CallbackContext context);
    }
}
