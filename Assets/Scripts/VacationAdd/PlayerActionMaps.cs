//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/VactionAdd/PlayerActionMaps.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerActionMaps : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionMaps()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionMaps"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""520fc260-5574-45f1-b46c-44660a045bc9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1427babb-4daa-4b9a-a0fd-c26a484ffd4d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""12ae8c9d-54a6-46e4-8ed3-32ee916957db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""72cbb024-67d4-4621-abcc-d62765455a51"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""VRLook"",
                    ""type"": ""Value"",
                    ""id"": ""db6e4444-7401-43ab-af59-4ed36f67a8bf"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""eeabc4d3-debf-4b55-ad10-18f0738f3041"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""VRInteract"",
                    ""type"": ""Button"",
                    ""id"": ""43d2b260-15a4-4e8f-a42f-ab7b1dc95aa3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8d20490b-4816-4024-a3ee-0fe1392e008d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c066f170-814d-42da-9692-a7d5a254e62a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4f3d1caa-8772-4862-8881-20d32fefb214"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9a81a554-3065-4004-88c3-77aee034971b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ea54af74-627e-4481-be5a-f0d7b263ecc1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""36b3cc96-0461-4755-a407-452e394be5b0"",
                    ""path"": ""<XRController>{RightHand}/touchpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""079d9151-6de7-4ac6-b868-8a0cbc90822d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f9556a8-81e2-4d2a-9d35-367dd3860f6d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""300006fe-909b-45ba-b081-13ee34b31b1e"",
                    ""path"": ""<XRHMD>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VRLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a65cf087-c73d-4cb8-a912-3e44cf6ef074"",
                    ""path"": ""<XRController>{RightHand}/touchpadClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""caa50a6a-341c-4cdd-8d4e-b0780d1b3457"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00a77e33-8ed9-4548-b9b5-ea84951ee43b"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VRInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27f07f05-926b-4d93-91f5-ff5736b0000a"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VRInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Testing"",
            ""id"": ""27bef5e7-62bf-4b89-817d-fe153e78a14e"",
            ""actions"": [
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""55d471f1-cc75-4d32-bb47-7d0cd1e82254"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Replay"",
                    ""type"": ""Button"",
                    ""id"": ""086cda7e-3e34-426d-b328-3af89d0f1bab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightOff"",
                    ""type"": ""Button"",
                    ""id"": ""60539944-1b04-4b1b-9520-bfac7ce8d8a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ab09a4b7-e207-4ed4-9817-66cc9bbe593b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b349c181-34ad-427c-8b0f-e9f381150631"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Replay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2790b302-6eb9-449d-814b-6f95c7f7cbd4"",
                    ""path"": ""<XRController>{RightHand}/back"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Replay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d931b783-60a1-420c-a106-8abe060d282f"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""OculusVR"",
            ""bindingGroup"": ""OculusVR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_VRLook = m_Player.FindAction("VRLook", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_VRInteract = m_Player.FindAction("VRInteract", throwIfNotFound: true);
        // Testing
        m_Testing = asset.FindActionMap("Testing", throwIfNotFound: true);
        m_Testing_Space = m_Testing.FindAction("Space", throwIfNotFound: true);
        m_Testing_Replay = m_Testing.FindAction("Replay", throwIfNotFound: true);
        m_Testing_LightOff = m_Testing.FindAction("LightOff", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_VRLook;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_VRInteract;
    public struct PlayerActions
    {
        private @PlayerActionMaps m_Wrapper;
        public PlayerActions(@PlayerActionMaps wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @VRLook => m_Wrapper.m_Player_VRLook;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @VRInteract => m_Wrapper.m_Player_VRInteract;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @VRLook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVRLook;
                @VRLook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVRLook;
                @VRLook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVRLook;
                @Run.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRun;
                @VRInteract.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVRInteract;
                @VRInteract.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVRInteract;
                @VRInteract.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVRInteract;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @VRLook.started += instance.OnVRLook;
                @VRLook.performed += instance.OnVRLook;
                @VRLook.canceled += instance.OnVRLook;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @VRInteract.started += instance.OnVRInteract;
                @VRInteract.performed += instance.OnVRInteract;
                @VRInteract.canceled += instance.OnVRInteract;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Testing
    private readonly InputActionMap m_Testing;
    private ITestingActions m_TestingActionsCallbackInterface;
    private readonly InputAction m_Testing_Space;
    private readonly InputAction m_Testing_Replay;
    private readonly InputAction m_Testing_LightOff;
    public struct TestingActions
    {
        private @PlayerActionMaps m_Wrapper;
        public TestingActions(@PlayerActionMaps wrapper) { m_Wrapper = wrapper; }
        public InputAction @Space => m_Wrapper.m_Testing_Space;
        public InputAction @Replay => m_Wrapper.m_Testing_Replay;
        public InputAction @LightOff => m_Wrapper.m_Testing_LightOff;
        public InputActionMap Get() { return m_Wrapper.m_Testing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestingActions set) { return set.Get(); }
        public void SetCallbacks(ITestingActions instance)
        {
            if (m_Wrapper.m_TestingActionsCallbackInterface != null)
            {
                @Space.started -= m_Wrapper.m_TestingActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_TestingActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_TestingActionsCallbackInterface.OnSpace;
                @Replay.started -= m_Wrapper.m_TestingActionsCallbackInterface.OnReplay;
                @Replay.performed -= m_Wrapper.m_TestingActionsCallbackInterface.OnReplay;
                @Replay.canceled -= m_Wrapper.m_TestingActionsCallbackInterface.OnReplay;
                @LightOff.started -= m_Wrapper.m_TestingActionsCallbackInterface.OnLightOff;
                @LightOff.performed -= m_Wrapper.m_TestingActionsCallbackInterface.OnLightOff;
                @LightOff.canceled -= m_Wrapper.m_TestingActionsCallbackInterface.OnLightOff;
            }
            m_Wrapper.m_TestingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @Replay.started += instance.OnReplay;
                @Replay.performed += instance.OnReplay;
                @Replay.canceled += instance.OnReplay;
                @LightOff.started += instance.OnLightOff;
                @LightOff.performed += instance.OnLightOff;
                @LightOff.canceled += instance.OnLightOff;
            }
        }
    }
    public TestingActions @Testing => new TestingActions(this);
    private int m_OculusVRSchemeIndex = -1;
    public InputControlScheme OculusVRScheme
    {
        get
        {
            if (m_OculusVRSchemeIndex == -1) m_OculusVRSchemeIndex = asset.FindControlSchemeIndex("OculusVR");
            return asset.controlSchemes[m_OculusVRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnVRLook(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnVRInteract(InputAction.CallbackContext context);
    }
    public interface ITestingActions
    {
        void OnSpace(InputAction.CallbackContext context);
        void OnReplay(InputAction.CallbackContext context);
        void OnLightOff(InputAction.CallbackContext context);
    }
}
