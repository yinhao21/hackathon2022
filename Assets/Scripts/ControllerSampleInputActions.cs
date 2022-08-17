// GENERATED AUTOMATICALLY FROM 'Assets/ControllerSample/InputActions/ControllerSampleInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerSampleInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerSampleInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerSampleInputActions"",
    ""maps"": [
        {
            ""name"": ""RightController"",
            ""id"": ""0d83ca55-7ddb-4dc8-a1b8-b667fb447ea3"",
            ""actions"": [
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""a40102d7-3f0a-47cb-9fe7-9c10882984e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Button"",
                    ""id"": ""0dfd212d-78dc-47a1-8076-e1bbc99cf1e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AX"",
                    ""type"": ""Button"",
                    ""id"": ""9192d49a-08f2-4086-aa31-c8230a65be5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BY"",
                    ""type"": ""Button"",
                    ""id"": ""1be3ff26-46c8-4299-b7a6-26a015689012"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoystickClick"",
                    ""type"": ""Button"",
                    ""id"": ""2414c9f0-e4ea-437e-94a1-3a0be22a56ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""App"",
                    ""type"": ""Button"",
                    ""id"": ""c5ced84e-b4d9-4190-89f0-408c5a93a933"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""69bb2a1a-94c9-4323-ad9d-ec657812e9de"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4540ab38-57a0-4c0e-ba6b-f7aa30ec821d"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a334860b-4314-42e4-9770-71967f743acb"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55d2fdbb-70a4-4baf-98d6-8270b0acad06"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99ee062a-e63a-40c2-91a4-7351838505b3"",
                    ""path"": ""<XRController>{RightHand}/primary2DAxisClick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8980c5de-9c7a-4ba0-84e0-4a126cec0c3f"",
                    ""path"": ""<XRController>{RightHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""App"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftController"",
            ""id"": ""722cc55d-eb5d-46bb-a018-e7301750dc57"",
            ""actions"": [
                {
                    ""name"": ""App"",
                    ""type"": ""Button"",
                    ""id"": ""a03b2790-280e-4768-b30a-a9b9f9899b2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoystickClick"",
                    ""type"": ""Button"",
                    ""id"": ""ce5b5d4e-9094-4d2c-b9f9-53b13f10fbce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BY"",
                    ""type"": ""Button"",
                    ""id"": ""22b17e08-2dbc-46dc-8fd8-ff6b5c967c62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AX"",
                    ""type"": ""Button"",
                    ""id"": ""5676308a-6cfd-478c-9430-c6bdd0ba0c75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Button"",
                    ""id"": ""9272183f-8416-4f2a-bc4b-bca4608b4cdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""20968439-2ee3-428a-bc43-a256654774b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b345fe39-d349-4f4e-89a3-31029b6c8383"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d13f8b92-a9c9-49cd-8f80-2baecc6d6e71"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69964ebd-d78e-4525-aa5e-34755f5ee1b3"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50d6b296-7faf-48e5-952b-57e28c3658f8"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67eaceaf-16ce-40f6-af33-ee2d19868d2a"",
                    ""path"": ""<XRController>{LeftHand}/primary2DAxisClick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e449a72-85e1-4a80-a9ae-bac6e99e29f0"",
                    ""path"": ""<XRController>{LeftHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""App"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightController
        m_RightController = asset.FindActionMap("RightController", throwIfNotFound: true);
        m_RightController_Trigger = m_RightController.FindAction("Trigger", throwIfNotFound: true);
        m_RightController_Grip = m_RightController.FindAction("Grip", throwIfNotFound: true);
        m_RightController_AX = m_RightController.FindAction("AX", throwIfNotFound: true);
        m_RightController_BY = m_RightController.FindAction("BY", throwIfNotFound: true);
        m_RightController_JoystickClick = m_RightController.FindAction("JoystickClick", throwIfNotFound: true);
        m_RightController_App = m_RightController.FindAction("App", throwIfNotFound: true);
        // LeftController
        m_LeftController = asset.FindActionMap("LeftController", throwIfNotFound: true);
        m_LeftController_App = m_LeftController.FindAction("App", throwIfNotFound: true);
        m_LeftController_JoystickClick = m_LeftController.FindAction("JoystickClick", throwIfNotFound: true);
        m_LeftController_BY = m_LeftController.FindAction("BY", throwIfNotFound: true);
        m_LeftController_AX = m_LeftController.FindAction("AX", throwIfNotFound: true);
        m_LeftController_Grip = m_LeftController.FindAction("Grip", throwIfNotFound: true);
        m_LeftController_Trigger = m_LeftController.FindAction("Trigger", throwIfNotFound: true);
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

    // RightController
    private readonly InputActionMap m_RightController;
    private IRightControllerActions m_RightControllerActionsCallbackInterface;
    private readonly InputAction m_RightController_Trigger;
    private readonly InputAction m_RightController_Grip;
    private readonly InputAction m_RightController_AX;
    private readonly InputAction m_RightController_BY;
    private readonly InputAction m_RightController_JoystickClick;
    private readonly InputAction m_RightController_App;
    public struct RightControllerActions
    {
        private @ControllerSampleInputActions m_Wrapper;
        public RightControllerActions(@ControllerSampleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Trigger => m_Wrapper.m_RightController_Trigger;
        public InputAction @Grip => m_Wrapper.m_RightController_Grip;
        public InputAction @AX => m_Wrapper.m_RightController_AX;
        public InputAction @BY => m_Wrapper.m_RightController_BY;
        public InputAction @JoystickClick => m_Wrapper.m_RightController_JoystickClick;
        public InputAction @App => m_Wrapper.m_RightController_App;
        public InputActionMap Get() { return m_Wrapper.m_RightController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightControllerActions set) { return set.Get(); }
        public void SetCallbacks(IRightControllerActions instance)
        {
            if (m_Wrapper.m_RightControllerActionsCallbackInterface != null)
            {
                @Trigger.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnTrigger;
                @Grip.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnGrip;
                @AX.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnAX;
                @AX.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnAX;
                @AX.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnAX;
                @BY.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnBY;
                @BY.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnBY;
                @BY.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnBY;
                @JoystickClick.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnJoystickClick;
                @JoystickClick.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnJoystickClick;
                @JoystickClick.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnJoystickClick;
                @App.started -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnApp;
                @App.performed -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnApp;
                @App.canceled -= m_Wrapper.m_RightControllerActionsCallbackInterface.OnApp;
            }
            m_Wrapper.m_RightControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @AX.started += instance.OnAX;
                @AX.performed += instance.OnAX;
                @AX.canceled += instance.OnAX;
                @BY.started += instance.OnBY;
                @BY.performed += instance.OnBY;
                @BY.canceled += instance.OnBY;
                @JoystickClick.started += instance.OnJoystickClick;
                @JoystickClick.performed += instance.OnJoystickClick;
                @JoystickClick.canceled += instance.OnJoystickClick;
                @App.started += instance.OnApp;
                @App.performed += instance.OnApp;
                @App.canceled += instance.OnApp;
            }
        }
    }
    public RightControllerActions @RightController => new RightControllerActions(this);

    // LeftController
    private readonly InputActionMap m_LeftController;
    private ILeftControllerActions m_LeftControllerActionsCallbackInterface;
    private readonly InputAction m_LeftController_App;
    private readonly InputAction m_LeftController_JoystickClick;
    private readonly InputAction m_LeftController_BY;
    private readonly InputAction m_LeftController_AX;
    private readonly InputAction m_LeftController_Grip;
    private readonly InputAction m_LeftController_Trigger;
    public struct LeftControllerActions
    {
        private @ControllerSampleInputActions m_Wrapper;
        public LeftControllerActions(@ControllerSampleInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @App => m_Wrapper.m_LeftController_App;
        public InputAction @JoystickClick => m_Wrapper.m_LeftController_JoystickClick;
        public InputAction @BY => m_Wrapper.m_LeftController_BY;
        public InputAction @AX => m_Wrapper.m_LeftController_AX;
        public InputAction @Grip => m_Wrapper.m_LeftController_Grip;
        public InputAction @Trigger => m_Wrapper.m_LeftController_Trigger;
        public InputActionMap Get() { return m_Wrapper.m_LeftController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftControllerActions set) { return set.Get(); }
        public void SetCallbacks(ILeftControllerActions instance)
        {
            if (m_Wrapper.m_LeftControllerActionsCallbackInterface != null)
            {
                @App.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnApp;
                @App.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnApp;
                @App.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnApp;
                @JoystickClick.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnJoystickClick;
                @JoystickClick.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnJoystickClick;
                @JoystickClick.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnJoystickClick;
                @BY.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnBY;
                @BY.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnBY;
                @BY.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnBY;
                @AX.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnAX;
                @AX.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnAX;
                @AX.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnAX;
                @Grip.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_LeftControllerActionsCallbackInterface.OnTrigger;
            }
            m_Wrapper.m_LeftControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @App.started += instance.OnApp;
                @App.performed += instance.OnApp;
                @App.canceled += instance.OnApp;
                @JoystickClick.started += instance.OnJoystickClick;
                @JoystickClick.performed += instance.OnJoystickClick;
                @JoystickClick.canceled += instance.OnJoystickClick;
                @BY.started += instance.OnBY;
                @BY.performed += instance.OnBY;
                @BY.canceled += instance.OnBY;
                @AX.started += instance.OnAX;
                @AX.performed += instance.OnAX;
                @AX.canceled += instance.OnAX;
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
            }
        }
    }
    public LeftControllerActions @LeftController => new LeftControllerActions(this);
    public interface IRightControllerActions
    {
        void OnTrigger(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnAX(InputAction.CallbackContext context);
        void OnBY(InputAction.CallbackContext context);
        void OnJoystickClick(InputAction.CallbackContext context);
        void OnApp(InputAction.CallbackContext context);
    }
    public interface ILeftControllerActions
    {
        void OnApp(InputAction.CallbackContext context);
        void OnJoystickClick(InputAction.CallbackContext context);
        void OnBY(InputAction.CallbackContext context);
        void OnAX(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
    }
}
