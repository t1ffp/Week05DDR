//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/DDR/DDRActions.inputactions
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

public partial class @DDRInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DDRInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DDRActions"",
    ""maps"": [
        {
            ""name"": ""DDR"",
            ""id"": ""40c8033d-85c6-4627-ad8c-5aaacba8bb58"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""88bf3e75-a059-4a52-826a-caba94e04a12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""6499a79e-0643-47ae-9957-ccc2a2e0c08a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""13f46f14-1f3c-4210-823e-49dcdd5d63ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""00f13d37-abf9-4812-b2a5-b8f1033cb35e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""64ef8823-a96a-4b0e-8e86-f5456c44a072"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""755e9784-dcc0-49de-a88d-223948aa0d94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""3e4c6409-fbb9-4290-ac7a-38e8d11ca3fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""49c646d9-c8eb-4601-8699-17ebff2349aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""43024b0f-8042-4f3e-84e2-baa9d76df0a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""e7e7f266-0e48-4491-9ddf-aaa9bb406947"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Center"",
                    ""type"": ""Button"",
                    ""id"": ""1e312712-47bc-45ea-83f5-83253d859454"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a01031b2-d6d2-4cd6-b7f4-c7531bd35a83"",
                    ""path"": ""<HID::USB Gamepad >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7b9f9d1-a98b-4d6f-853f-f5e18c26e588"",
                    ""path"": ""<HID::USB Gamepad >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74646b13-2dce-45e8-a140-f7a7c4af81eb"",
                    ""path"": ""<HID::USB Gamepad >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c16adbb-dd41-476c-a329-ab4cb2a48a57"",
                    ""path"": ""<HID::USB Gamepad >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1d5b13e-2ab6-4fb5-965c-8cc8f2ef9dcd"",
                    ""path"": ""<HID::USB Gamepad >/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cb946e5-4486-4a61-a2cc-77ca793bf18d"",
                    ""path"": ""<HID::USB Gamepad >/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67115b09-0b1a-4517-92eb-c59e7333bc45"",
                    ""path"": ""<HID::USB Gamepad >/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""360dd279-f5d2-4ea5-83f3-404d31aa46bc"",
                    ""path"": ""<HID::USB Gamepad >/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""452e3ed7-417e-45cd-8c2a-15377cf1546f"",
                    ""path"": ""<HID::USB Gamepad >/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d1d48bb-6e69-42a0-99a0-f0377ff723c0"",
                    ""path"": ""<HID::USB Gamepad >/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a352fda8-b275-4955-b75f-f4dacb41b1cd"",
                    ""path"": ""<HID::USB Gamepad >/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Center"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DDR
        m_DDR = asset.FindActionMap("DDR", throwIfNotFound: true);
        m_DDR_Up = m_DDR.FindAction("Up", throwIfNotFound: true);
        m_DDR_Down = m_DDR.FindAction("Down", throwIfNotFound: true);
        m_DDR_Right = m_DDR.FindAction("Right", throwIfNotFound: true);
        m_DDR_Left = m_DDR.FindAction("Left", throwIfNotFound: true);
        m_DDR_Cross = m_DDR.FindAction("Cross", throwIfNotFound: true);
        m_DDR_Square = m_DDR.FindAction("Square", throwIfNotFound: true);
        m_DDR_Circle = m_DDR.FindAction("Circle", throwIfNotFound: true);
        m_DDR_Triangle = m_DDR.FindAction("Triangle", throwIfNotFound: true);
        m_DDR_Start = m_DDR.FindAction("Start", throwIfNotFound: true);
        m_DDR_Select = m_DDR.FindAction("Select", throwIfNotFound: true);
        m_DDR_Center = m_DDR.FindAction("Center", throwIfNotFound: true);
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

    // DDR
    private readonly InputActionMap m_DDR;
    private List<IDDRActions> m_DDRActionsCallbackInterfaces = new List<IDDRActions>();
    private readonly InputAction m_DDR_Up;
    private readonly InputAction m_DDR_Down;
    private readonly InputAction m_DDR_Right;
    private readonly InputAction m_DDR_Left;
    private readonly InputAction m_DDR_Cross;
    private readonly InputAction m_DDR_Square;
    private readonly InputAction m_DDR_Circle;
    private readonly InputAction m_DDR_Triangle;
    private readonly InputAction m_DDR_Start;
    private readonly InputAction m_DDR_Select;
    private readonly InputAction m_DDR_Center;
    public struct DDRActions
    {
        private @DDRInput m_Wrapper;
        public DDRActions(@DDRInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_DDR_Up;
        public InputAction @Down => m_Wrapper.m_DDR_Down;
        public InputAction @Right => m_Wrapper.m_DDR_Right;
        public InputAction @Left => m_Wrapper.m_DDR_Left;
        public InputAction @Cross => m_Wrapper.m_DDR_Cross;
        public InputAction @Square => m_Wrapper.m_DDR_Square;
        public InputAction @Circle => m_Wrapper.m_DDR_Circle;
        public InputAction @Triangle => m_Wrapper.m_DDR_Triangle;
        public InputAction @Start => m_Wrapper.m_DDR_Start;
        public InputAction @Select => m_Wrapper.m_DDR_Select;
        public InputAction @Center => m_Wrapper.m_DDR_Center;
        public InputActionMap Get() { return m_Wrapper.m_DDR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DDRActions set) { return set.Get(); }
        public void AddCallbacks(IDDRActions instance)
        {
            if (instance == null || m_Wrapper.m_DDRActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DDRActionsCallbackInterfaces.Add(instance);
            @Up.started += instance.OnUp;
            @Up.performed += instance.OnUp;
            @Up.canceled += instance.OnUp;
            @Down.started += instance.OnDown;
            @Down.performed += instance.OnDown;
            @Down.canceled += instance.OnDown;
            @Right.started += instance.OnRight;
            @Right.performed += instance.OnRight;
            @Right.canceled += instance.OnRight;
            @Left.started += instance.OnLeft;
            @Left.performed += instance.OnLeft;
            @Left.canceled += instance.OnLeft;
            @Cross.started += instance.OnCross;
            @Cross.performed += instance.OnCross;
            @Cross.canceled += instance.OnCross;
            @Square.started += instance.OnSquare;
            @Square.performed += instance.OnSquare;
            @Square.canceled += instance.OnSquare;
            @Circle.started += instance.OnCircle;
            @Circle.performed += instance.OnCircle;
            @Circle.canceled += instance.OnCircle;
            @Triangle.started += instance.OnTriangle;
            @Triangle.performed += instance.OnTriangle;
            @Triangle.canceled += instance.OnTriangle;
            @Start.started += instance.OnStart;
            @Start.performed += instance.OnStart;
            @Start.canceled += instance.OnStart;
            @Select.started += instance.OnSelect;
            @Select.performed += instance.OnSelect;
            @Select.canceled += instance.OnSelect;
            @Center.started += instance.OnCenter;
            @Center.performed += instance.OnCenter;
            @Center.canceled += instance.OnCenter;
        }

        private void UnregisterCallbacks(IDDRActions instance)
        {
            @Up.started -= instance.OnUp;
            @Up.performed -= instance.OnUp;
            @Up.canceled -= instance.OnUp;
            @Down.started -= instance.OnDown;
            @Down.performed -= instance.OnDown;
            @Down.canceled -= instance.OnDown;
            @Right.started -= instance.OnRight;
            @Right.performed -= instance.OnRight;
            @Right.canceled -= instance.OnRight;
            @Left.started -= instance.OnLeft;
            @Left.performed -= instance.OnLeft;
            @Left.canceled -= instance.OnLeft;
            @Cross.started -= instance.OnCross;
            @Cross.performed -= instance.OnCross;
            @Cross.canceled -= instance.OnCross;
            @Square.started -= instance.OnSquare;
            @Square.performed -= instance.OnSquare;
            @Square.canceled -= instance.OnSquare;
            @Circle.started -= instance.OnCircle;
            @Circle.performed -= instance.OnCircle;
            @Circle.canceled -= instance.OnCircle;
            @Triangle.started -= instance.OnTriangle;
            @Triangle.performed -= instance.OnTriangle;
            @Triangle.canceled -= instance.OnTriangle;
            @Start.started -= instance.OnStart;
            @Start.performed -= instance.OnStart;
            @Start.canceled -= instance.OnStart;
            @Select.started -= instance.OnSelect;
            @Select.performed -= instance.OnSelect;
            @Select.canceled -= instance.OnSelect;
            @Center.started -= instance.OnCenter;
            @Center.performed -= instance.OnCenter;
            @Center.canceled -= instance.OnCenter;
        }

        public void RemoveCallbacks(IDDRActions instance)
        {
            if (m_Wrapper.m_DDRActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDDRActions instance)
        {
            foreach (var item in m_Wrapper.m_DDRActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DDRActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DDRActions @DDR => new DDRActions(this);
    public interface IDDRActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnCross(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnCenter(InputAction.CallbackContext context);
    }
}
