//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Gameplay/Input/InputMap.inputactions
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

public partial class @InputMap: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d0f1861c-86de-4535-8522-7f482c8acb6e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8db1f2ee-681b-4a5d-91d3-830ebe19df27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""330b91a9-2b41-4d9b-a3ec-54f35632dda2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""ec967b01-9207-4e22-8813-ca8e45c86aeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LAtk"",
                    ""type"": ""Button"",
                    ""id"": ""b0974157-ef36-4fa9-a038-9a4f43a81a4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RAtk"",
                    ""type"": ""Button"",
                    ""id"": ""1dfc57bf-23b1-4764-a2e0-a21d39defc4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ULAtk"",
                    ""type"": ""Button"",
                    ""id"": ""577ec11b-e724-40eb-9d95-7659c8d54970"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""URAtk"",
                    ""type"": ""Button"",
                    ""id"": ""f523abfd-b5d4-4977-849c-d46ff12b1492"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DLAtk"",
                    ""type"": ""Button"",
                    ""id"": ""dcf28d78-6e16-4d5c-9b53-7498afa14057"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DRAtk"",
                    ""type"": ""Button"",
                    ""id"": ""736205fa-be07-432d-b82d-6319ceaebad4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Accessorie"",
                    ""type"": ""Button"",
                    ""id"": ""99a3edd7-8ba7-45d7-a7e0-a98ffc256d4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2fe8a967-990d-45f1-976c-3c81cc1291ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Map"",
                    ""type"": ""Button"",
                    ""id"": ""1823c95d-ea93-4cff-8de0-6d26c3c060aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Upgrade"",
                    ""type"": ""Button"",
                    ""id"": ""9b90be1a-e76c-4276-91fd-f0db99a13b93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NormalForm"",
                    ""type"": ""Button"",
                    ""id"": ""bd471069-a2dd-4730-bdf2-475b9917b294"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MagicalForm"",
                    ""type"": ""Button"",
                    ""id"": ""5fcc65e5-9863-4fed-9c19-66f5d3b4092f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KnightForm"",
                    ""type"": ""Button"",
                    ""id"": ""61eb64da-f1f6-4ed4-a3de-add04e5958aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NanoMachineForm"",
                    ""type"": ""Button"",
                    ""id"": ""b0799129-18bd-4c9f-aeb7-b2a83d2bcee5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LimitBreakForm"",
                    ""type"": ""Button"",
                    ""id"": ""664aa218-60f5-46cb-b53f-d99fb1f465c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1694528d-83a0-4214-a87e-4e501e7e7eb7"",
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
                    ""id"": ""c49a3745-1b90-4b12-a2d2-204feb354483"",
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
                    ""id"": ""bd9c2bf9-a959-4b8c-b6d6-9184e9b02117"",
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
                    ""id"": ""0492e283-9840-4bf3-95df-595fc0b18efa"",
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
                    ""id"": ""563184c0-64cc-4855-b1f4-e59ea221ffc3"",
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
                    ""id"": ""dfa8815b-0f7b-41b1-b2ba-c25e2eda91da"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8781ed0b-e413-45bb-b05c-040ec89701ae"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54cb5417-01f1-4063-ab3b-fc0f8a6dde41"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96ff60be-501d-4061-85e7-6a375f5edc35"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""7411a8e4-4481-4280-b606-fd48bd2dfb4b"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ULAtk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""02ad69ad-2669-4a7c-b805-0d5158d679b4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ULAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""430fc5a4-20f0-47fd-94f9-3f81dded5f1d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ULAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""bc8645fd-e2d1-47f0-ba05-3ba0806c9743"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""URAtk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f2e4c811-2c61-4a40-a36e-b9122cfea77d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""URAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""b1baedb1-29f6-41d2-bd6d-aea519ab9e71"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""URAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""88e76b2c-ff23-4d06-8f50-261255b106c8"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DLAtk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""e47d6076-990a-44c0-9724-7ece0393f5d7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DLAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""1b78ccf7-d708-4c43-8a35-68860b0a83dc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DLAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""a99d7c21-ff68-4cd3-819f-9788ebbea6b9"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DRAtk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ff011cdc-094c-4353-989d-4d96749c0a83"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DRAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""70656632-eefe-4db7-927e-69e5c6a6918b"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DRAtk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4e20d166-9f6b-44bd-81f1-293b10db4c9b"",
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
                    ""id"": ""c029744c-9db5-43af-8a3d-22d78a2b9c85"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accessorie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9eabed5-cef7-4017-a356-61584828d33f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Upgrade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e18ec857-a2b6-4d01-9122-7bb0242d662c"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Map"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2143e75e-b067-4afc-85b1-a8c490f752db"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NormalForm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60f75690-a53c-4690-b87e-7df27fcf325a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MagicalForm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8f57c01-e8b4-4a65-b6ac-5e728547d54e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KnightForm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fa17348-cd7f-4093-83eb-04999a78c8d8"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NanoMachineForm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3bfe608-ae62-4f6c-9e17-aa077435c7f4"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LimitBreakForm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""665da317-b502-4b6b-9f27-6ce2341facae"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""70eec484-df8d-44c1-bc97-4d6e3c359b04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3f55b180-d741-43d2-bc02-cb3f20da340b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_LAtk = m_Gameplay.FindAction("LAtk", throwIfNotFound: true);
        m_Gameplay_RAtk = m_Gameplay.FindAction("RAtk", throwIfNotFound: true);
        m_Gameplay_ULAtk = m_Gameplay.FindAction("ULAtk", throwIfNotFound: true);
        m_Gameplay_URAtk = m_Gameplay.FindAction("URAtk", throwIfNotFound: true);
        m_Gameplay_DLAtk = m_Gameplay.FindAction("DLAtk", throwIfNotFound: true);
        m_Gameplay_DRAtk = m_Gameplay.FindAction("DRAtk", throwIfNotFound: true);
        m_Gameplay_Accessorie = m_Gameplay.FindAction("Accessorie", throwIfNotFound: true);
        m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
        m_Gameplay_Map = m_Gameplay.FindAction("Map", throwIfNotFound: true);
        m_Gameplay_Upgrade = m_Gameplay.FindAction("Upgrade", throwIfNotFound: true);
        m_Gameplay_NormalForm = m_Gameplay.FindAction("NormalForm", throwIfNotFound: true);
        m_Gameplay_MagicalForm = m_Gameplay.FindAction("MagicalForm", throwIfNotFound: true);
        m_Gameplay_KnightForm = m_Gameplay.FindAction("KnightForm", throwIfNotFound: true);
        m_Gameplay_NanoMachineForm = m_Gameplay.FindAction("NanoMachineForm", throwIfNotFound: true);
        m_Gameplay_LimitBreakForm = m_Gameplay.FindAction("LimitBreakForm", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_LAtk;
    private readonly InputAction m_Gameplay_RAtk;
    private readonly InputAction m_Gameplay_ULAtk;
    private readonly InputAction m_Gameplay_URAtk;
    private readonly InputAction m_Gameplay_DLAtk;
    private readonly InputAction m_Gameplay_DRAtk;
    private readonly InputAction m_Gameplay_Accessorie;
    private readonly InputAction m_Gameplay_Interact;
    private readonly InputAction m_Gameplay_Map;
    private readonly InputAction m_Gameplay_Upgrade;
    private readonly InputAction m_Gameplay_NormalForm;
    private readonly InputAction m_Gameplay_MagicalForm;
    private readonly InputAction m_Gameplay_KnightForm;
    private readonly InputAction m_Gameplay_NanoMachineForm;
    private readonly InputAction m_Gameplay_LimitBreakForm;
    public struct GameplayActions
    {
        private @InputMap m_Wrapper;
        public GameplayActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @LAtk => m_Wrapper.m_Gameplay_LAtk;
        public InputAction @RAtk => m_Wrapper.m_Gameplay_RAtk;
        public InputAction @ULAtk => m_Wrapper.m_Gameplay_ULAtk;
        public InputAction @URAtk => m_Wrapper.m_Gameplay_URAtk;
        public InputAction @DLAtk => m_Wrapper.m_Gameplay_DLAtk;
        public InputAction @DRAtk => m_Wrapper.m_Gameplay_DRAtk;
        public InputAction @Accessorie => m_Wrapper.m_Gameplay_Accessorie;
        public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
        public InputAction @Map => m_Wrapper.m_Gameplay_Map;
        public InputAction @Upgrade => m_Wrapper.m_Gameplay_Upgrade;
        public InputAction @NormalForm => m_Wrapper.m_Gameplay_NormalForm;
        public InputAction @MagicalForm => m_Wrapper.m_Gameplay_MagicalForm;
        public InputAction @KnightForm => m_Wrapper.m_Gameplay_KnightForm;
        public InputAction @NanoMachineForm => m_Wrapper.m_Gameplay_NanoMachineForm;
        public InputAction @LimitBreakForm => m_Wrapper.m_Gameplay_LimitBreakForm;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @LAtk.started += instance.OnLAtk;
            @LAtk.performed += instance.OnLAtk;
            @LAtk.canceled += instance.OnLAtk;
            @RAtk.started += instance.OnRAtk;
            @RAtk.performed += instance.OnRAtk;
            @RAtk.canceled += instance.OnRAtk;
            @ULAtk.started += instance.OnULAtk;
            @ULAtk.performed += instance.OnULAtk;
            @ULAtk.canceled += instance.OnULAtk;
            @URAtk.started += instance.OnURAtk;
            @URAtk.performed += instance.OnURAtk;
            @URAtk.canceled += instance.OnURAtk;
            @DLAtk.started += instance.OnDLAtk;
            @DLAtk.performed += instance.OnDLAtk;
            @DLAtk.canceled += instance.OnDLAtk;
            @DRAtk.started += instance.OnDRAtk;
            @DRAtk.performed += instance.OnDRAtk;
            @DRAtk.canceled += instance.OnDRAtk;
            @Accessorie.started += instance.OnAccessorie;
            @Accessorie.performed += instance.OnAccessorie;
            @Accessorie.canceled += instance.OnAccessorie;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Map.started += instance.OnMap;
            @Map.performed += instance.OnMap;
            @Map.canceled += instance.OnMap;
            @Upgrade.started += instance.OnUpgrade;
            @Upgrade.performed += instance.OnUpgrade;
            @Upgrade.canceled += instance.OnUpgrade;
            @NormalForm.started += instance.OnNormalForm;
            @NormalForm.performed += instance.OnNormalForm;
            @NormalForm.canceled += instance.OnNormalForm;
            @MagicalForm.started += instance.OnMagicalForm;
            @MagicalForm.performed += instance.OnMagicalForm;
            @MagicalForm.canceled += instance.OnMagicalForm;
            @KnightForm.started += instance.OnKnightForm;
            @KnightForm.performed += instance.OnKnightForm;
            @KnightForm.canceled += instance.OnKnightForm;
            @NanoMachineForm.started += instance.OnNanoMachineForm;
            @NanoMachineForm.performed += instance.OnNanoMachineForm;
            @NanoMachineForm.canceled += instance.OnNanoMachineForm;
            @LimitBreakForm.started += instance.OnLimitBreakForm;
            @LimitBreakForm.performed += instance.OnLimitBreakForm;
            @LimitBreakForm.canceled += instance.OnLimitBreakForm;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @LAtk.started -= instance.OnLAtk;
            @LAtk.performed -= instance.OnLAtk;
            @LAtk.canceled -= instance.OnLAtk;
            @RAtk.started -= instance.OnRAtk;
            @RAtk.performed -= instance.OnRAtk;
            @RAtk.canceled -= instance.OnRAtk;
            @ULAtk.started -= instance.OnULAtk;
            @ULAtk.performed -= instance.OnULAtk;
            @ULAtk.canceled -= instance.OnULAtk;
            @URAtk.started -= instance.OnURAtk;
            @URAtk.performed -= instance.OnURAtk;
            @URAtk.canceled -= instance.OnURAtk;
            @DLAtk.started -= instance.OnDLAtk;
            @DLAtk.performed -= instance.OnDLAtk;
            @DLAtk.canceled -= instance.OnDLAtk;
            @DRAtk.started -= instance.OnDRAtk;
            @DRAtk.performed -= instance.OnDRAtk;
            @DRAtk.canceled -= instance.OnDRAtk;
            @Accessorie.started -= instance.OnAccessorie;
            @Accessorie.performed -= instance.OnAccessorie;
            @Accessorie.canceled -= instance.OnAccessorie;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Map.started -= instance.OnMap;
            @Map.performed -= instance.OnMap;
            @Map.canceled -= instance.OnMap;
            @Upgrade.started -= instance.OnUpgrade;
            @Upgrade.performed -= instance.OnUpgrade;
            @Upgrade.canceled -= instance.OnUpgrade;
            @NormalForm.started -= instance.OnNormalForm;
            @NormalForm.performed -= instance.OnNormalForm;
            @NormalForm.canceled -= instance.OnNormalForm;
            @MagicalForm.started -= instance.OnMagicalForm;
            @MagicalForm.performed -= instance.OnMagicalForm;
            @MagicalForm.canceled -= instance.OnMagicalForm;
            @KnightForm.started -= instance.OnKnightForm;
            @KnightForm.performed -= instance.OnKnightForm;
            @KnightForm.canceled -= instance.OnKnightForm;
            @NanoMachineForm.started -= instance.OnNanoMachineForm;
            @NanoMachineForm.performed -= instance.OnNanoMachineForm;
            @NanoMachineForm.canceled -= instance.OnNanoMachineForm;
            @LimitBreakForm.started -= instance.OnLimitBreakForm;
            @LimitBreakForm.performed -= instance.OnLimitBreakForm;
            @LimitBreakForm.canceled -= instance.OnLimitBreakForm;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @InputMap m_Wrapper;
        public UIActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnLAtk(InputAction.CallbackContext context);
        void OnRAtk(InputAction.CallbackContext context);
        void OnULAtk(InputAction.CallbackContext context);
        void OnURAtk(InputAction.CallbackContext context);
        void OnDLAtk(InputAction.CallbackContext context);
        void OnDRAtk(InputAction.CallbackContext context);
        void OnAccessorie(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMap(InputAction.CallbackContext context);
        void OnUpgrade(InputAction.CallbackContext context);
        void OnNormalForm(InputAction.CallbackContext context);
        void OnMagicalForm(InputAction.CallbackContext context);
        void OnKnightForm(InputAction.CallbackContext context);
        void OnNanoMachineForm(InputAction.CallbackContext context);
        void OnLimitBreakForm(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}