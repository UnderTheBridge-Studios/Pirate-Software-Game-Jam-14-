//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerInput/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""3a31eba2-b56b-4cc7-8acd-943cf68af912"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""564edae4-ac5e-434a-9714-c905d430207e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7ea59eb5-ca1a-4f83-a2ba-7cbf519a0b1b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""64c0c855-57e3-4af6-87b1-719d9510789f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Flashlight"",
                    ""type"": ""Button"",
                    ""id"": ""4374e6ec-918c-4914-b808-c3bfd4fcba70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""4607aa84-45f2-401c-8cf2-3f4758dde187"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Recharge"",
                    ""type"": ""Button"",
                    ""id"": ""060eadd0-1a0a-49a0-8388-cff0a69f64a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""6905b028-7eb4-43b9-bae0-f4298f0ff08d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ddec053a-90d4-48c4-8252-fdece2a1a527"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8a092ef8-f19f-458c-b27c-0bf62ec1f1c1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d9b3ffc1-b57d-4730-86f9-d41745bacc18"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c163b22-deae-4565-bec6-08df92d738ea"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""54b00633-f30b-4293-9243-ca61b126017c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9bf334d3-3fcb-43f0-8a9a-dc639e17c30f"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fe7730f-f1ca-475b-b9ec-96d1df53869f"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a8206ec-2f04-4539-bb38-273c0b4cb669"",
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
                    ""id"": ""f451c706-7e61-4d60-a29a-1c1b0dacb6da"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Recharge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuNavigation"",
            ""id"": ""fae829b7-23bb-4062-a935-a56bed7c1105"",
            ""actions"": [
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""74876b33-fe44-434c-bb12-b3adc76d372e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""52561caa-d8b7-44d7-a603-47a69bbe24d8"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""NotesPopUp"",
            ""id"": ""a164e7c7-5bda-4f2a-8cc9-ea811b8bf767"",
            ""actions"": [
                {
                    ""name"": ""CloseNote"",
                    ""type"": ""Button"",
                    ""id"": ""10bbe9a5-e631-4555-87fe-c18894047d80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b616ffb-ea15-4552-946c-9fd2d0b80c52"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseNote"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cea48597-e672-41c6-afa0-d39c3114f0a2"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseNote"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""799a6bf5-9b26-4340-81b6-058a3d5543b2"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseNote"",
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
        m_GamePlay_HorizontalMovement = m_GamePlay.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_GamePlay_Look = m_GamePlay.FindAction("Look", throwIfNotFound: true);
        m_GamePlay_Interact = m_GamePlay.FindAction("Interact", throwIfNotFound: true);
        m_GamePlay_Flashlight = m_GamePlay.FindAction("Flashlight", throwIfNotFound: true);
        m_GamePlay_Pause = m_GamePlay.FindAction("Pause", throwIfNotFound: true);
        m_GamePlay_Recharge = m_GamePlay.FindAction("Recharge", throwIfNotFound: true);
        // MenuNavigation
        m_MenuNavigation = asset.FindActionMap("MenuNavigation", throwIfNotFound: true);
        m_MenuNavigation_Resume = m_MenuNavigation.FindAction("Resume", throwIfNotFound: true);
        // NotesPopUp
        m_NotesPopUp = asset.FindActionMap("NotesPopUp", throwIfNotFound: true);
        m_NotesPopUp_CloseNote = m_NotesPopUp.FindAction("CloseNote", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private List<IGamePlayActions> m_GamePlayActionsCallbackInterfaces = new List<IGamePlayActions>();
    private readonly InputAction m_GamePlay_HorizontalMovement;
    private readonly InputAction m_GamePlay_Look;
    private readonly InputAction m_GamePlay_Interact;
    private readonly InputAction m_GamePlay_Flashlight;
    private readonly InputAction m_GamePlay_Pause;
    private readonly InputAction m_GamePlay_Recharge;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_GamePlay_HorizontalMovement;
        public InputAction @Look => m_Wrapper.m_GamePlay_Look;
        public InputAction @Interact => m_Wrapper.m_GamePlay_Interact;
        public InputAction @Flashlight => m_Wrapper.m_GamePlay_Flashlight;
        public InputAction @Pause => m_Wrapper.m_GamePlay_Pause;
        public InputAction @Recharge => m_Wrapper.m_GamePlay_Recharge;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Add(instance);
            @HorizontalMovement.started += instance.OnHorizontalMovement;
            @HorizontalMovement.performed += instance.OnHorizontalMovement;
            @HorizontalMovement.canceled += instance.OnHorizontalMovement;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Flashlight.started += instance.OnFlashlight;
            @Flashlight.performed += instance.OnFlashlight;
            @Flashlight.canceled += instance.OnFlashlight;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @Recharge.started += instance.OnRecharge;
            @Recharge.performed += instance.OnRecharge;
            @Recharge.canceled += instance.OnRecharge;
        }

        private void UnregisterCallbacks(IGamePlayActions instance)
        {
            @HorizontalMovement.started -= instance.OnHorizontalMovement;
            @HorizontalMovement.performed -= instance.OnHorizontalMovement;
            @HorizontalMovement.canceled -= instance.OnHorizontalMovement;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Flashlight.started -= instance.OnFlashlight;
            @Flashlight.performed -= instance.OnFlashlight;
            @Flashlight.canceled -= instance.OnFlashlight;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @Recharge.started -= instance.OnRecharge;
            @Recharge.performed -= instance.OnRecharge;
            @Recharge.canceled -= instance.OnRecharge;
        }

        public void RemoveCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // MenuNavigation
    private readonly InputActionMap m_MenuNavigation;
    private List<IMenuNavigationActions> m_MenuNavigationActionsCallbackInterfaces = new List<IMenuNavigationActions>();
    private readonly InputAction m_MenuNavigation_Resume;
    public struct MenuNavigationActions
    {
        private @PlayerControls m_Wrapper;
        public MenuNavigationActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Resume => m_Wrapper.m_MenuNavigation_Resume;
        public InputActionMap Get() { return m_Wrapper.m_MenuNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuNavigationActions set) { return set.Get(); }
        public void AddCallbacks(IMenuNavigationActions instance)
        {
            if (instance == null || m_Wrapper.m_MenuNavigationActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MenuNavigationActionsCallbackInterfaces.Add(instance);
            @Resume.started += instance.OnResume;
            @Resume.performed += instance.OnResume;
            @Resume.canceled += instance.OnResume;
        }

        private void UnregisterCallbacks(IMenuNavigationActions instance)
        {
            @Resume.started -= instance.OnResume;
            @Resume.performed -= instance.OnResume;
            @Resume.canceled -= instance.OnResume;
        }

        public void RemoveCallbacks(IMenuNavigationActions instance)
        {
            if (m_Wrapper.m_MenuNavigationActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMenuNavigationActions instance)
        {
            foreach (var item in m_Wrapper.m_MenuNavigationActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MenuNavigationActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MenuNavigationActions @MenuNavigation => new MenuNavigationActions(this);

    // NotesPopUp
    private readonly InputActionMap m_NotesPopUp;
    private List<INotesPopUpActions> m_NotesPopUpActionsCallbackInterfaces = new List<INotesPopUpActions>();
    private readonly InputAction m_NotesPopUp_CloseNote;
    public struct NotesPopUpActions
    {
        private @PlayerControls m_Wrapper;
        public NotesPopUpActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CloseNote => m_Wrapper.m_NotesPopUp_CloseNote;
        public InputActionMap Get() { return m_Wrapper.m_NotesPopUp; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NotesPopUpActions set) { return set.Get(); }
        public void AddCallbacks(INotesPopUpActions instance)
        {
            if (instance == null || m_Wrapper.m_NotesPopUpActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_NotesPopUpActionsCallbackInterfaces.Add(instance);
            @CloseNote.started += instance.OnCloseNote;
            @CloseNote.performed += instance.OnCloseNote;
            @CloseNote.canceled += instance.OnCloseNote;
        }

        private void UnregisterCallbacks(INotesPopUpActions instance)
        {
            @CloseNote.started -= instance.OnCloseNote;
            @CloseNote.performed -= instance.OnCloseNote;
            @CloseNote.canceled -= instance.OnCloseNote;
        }

        public void RemoveCallbacks(INotesPopUpActions instance)
        {
            if (m_Wrapper.m_NotesPopUpActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(INotesPopUpActions instance)
        {
            foreach (var item in m_Wrapper.m_NotesPopUpActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_NotesPopUpActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public NotesPopUpActions @NotesPopUp => new NotesPopUpActions(this);
    public interface IGamePlayActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnFlashlight(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnRecharge(InputAction.CallbackContext context);
    }
    public interface IMenuNavigationActions
    {
        void OnResume(InputAction.CallbackContext context);
    }
    public interface INotesPopUpActions
    {
        void OnCloseNote(InputAction.CallbackContext context);
    }
}
