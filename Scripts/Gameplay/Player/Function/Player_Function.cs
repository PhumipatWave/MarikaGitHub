using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

// This script use for store all value & function of Player
public class Player_Function : MonoBehaviour
{
    // Declare reference variables
    private InputMap _input;
    public Animator _anim;
    public Rigidbody2D _rb;

    public Player_StatsData _marikaStat;

    public Transform _groundCheck;
    public Transform _wallCheck;

    public LayerMask _groundLayer;

    // Variables to store player input values
    int _form = 1;
    bool _isWall;
    bool _isGround;
    bool _facingRight = true;
    Vector2 _currentMoveInput;
    Vector2 _zero = Vector2.zero;

    // State variables
    Player_BaseState _currentState;
    Player_StateFactory _state;

    // Getters and setters
    public Player_BaseState CurrentState { get { return _currentState; } set { _currentState = value; } }
    public Animator Anim { get { return _anim; } }
    public Rigidbody2D RB { get { return _rb; } set { _rb = value; } }

    public Vector2 CurrentMoveSpeed { get { return _currentMoveInput; } set { _currentMoveInput = value; } }
    public Vector2 VectorZero { get { return _zero; } }

    public int MarikaForm { get { return _form; } set { _form = value; } }

    public bool IsRunPressed { get { return _isRunPressed; } }
    public bool IsJumpPressed { get { return _isJumpPressed; } }
    public bool IsDashPressed { get { return _isDashPressed; } }
    public bool IsLAtkPressed { get { return _isLAtkPressed; } }
    public bool IsRAtkPressed { get { return _isRAtkPressed; } }
    public bool IsULAtkPressed { get { return _isULAtkPressed; } }
    public bool IsURAtkPressed { get { return _isURAtkPressed; } }
    public bool IsDLAtkPressed { get { return _isDLAtkPressed; } }
    public bool IsDRAtkPressed { get { return _isDRAtkPressed; } }
    public bool IsNormalPressed { get { return _isNormalPressed; } set { _isNormalPressed = value; } }
    public bool IsMagicalPressed { get { return _isMagicalPressed; } set { _isMagicalPressed = value; } }
    public bool IsKnightPressed { get { return _isKnightPressed; } set { _isKnightPressed = value; } }
    public bool IsNanoMachinePressed { get { return _isNanoMachinePressed; } set { _isNanoMachinePressed = value; } }
    public bool IsLimitBreakPressed { get { return _isLimitBreakPressed; } set { _isLimitBreakPressed = value; } }

    public bool IsWall { get { return _isWall; } set { _isWall = value; } }
    public bool IsGround { get { return _isGround; } set { _isGround = value; } }
    public bool IsFacingRight { get { return _facingRight; } set { _facingRight = value; } }
    public bool IsIdle { get { return _isIdle; } set { _isRun = value; } }
    public bool IsRun { get { return _isRun; } set { _isRun = value; } }
    public bool IsJump { get { return _isJump; } set { _isJump = value; } }
    public bool IsFall { get { return _isFall; } set { _isFall = value; } }
    public bool IsDash { get { return _isDash; } set { _isDash = value; } }
    public bool IsSuperDash { get { return _isSuperDash; } set { _isSuperDash = value; } }
    public bool IsDashAtk { get { return _isDashAtk; } set { _isDashAtk = value; } }
    public bool IsAirDash { get { return _isAirDash; } set { _isAirDash = value; } }
    public bool IsAirLAtk { get { return _isAirLAtk; } set { _isAirLAtk = value; } }
    public bool IsAirRAtk { get { return _isAirRAtk; } set { _isAirRAtk = value; } }
    public bool IsLAtk { get { return _isLAtk; } set { _isLAtk = value; } }
    public bool IsRAtk { get { return _isRAtk; } set { _isRAtk = value; } }
    public bool IsULAtk { get { return _isULAtk; } set { _isULAtk = value; } }
    public bool IsURAtk { get { return _isURAtk; } set { _isURAtk = value; } }
    public bool IsDLAtk { get { return _isDLAtk; } set { _isDLAtk = value; } }
    public bool IsDRAtk { get { return _isDRAtk; } set { _isDRAtk = value; } }
    public bool IsWallGrab { get { return _isWallGrab; } set { _isWallGrab = value; } }
    public bool IsNormalForm { get { return _isNormalForm; } set { _isNormalForm = value; } }
    public bool IsMagicalForm { get { return _isMagicalForm; } set { _isMagicalForm = value; } }
    public bool IsKnightForm { get { return _isKnightForm; } set { _isKnightForm = value; } }
    public bool IsNanoMachineForm { get { return _isNanoMachineForm; } set { _isNanoMachineForm = value; } }
    public bool IsLimitBreakForm { get { return _isLimitBreakForm; } set { _isLimitBreakForm = value; } }

    public float MoveSpeed { get { return _moveSpeed; } }
    public float JumpPower { get { return _jumpPower; } }
    public float JumpDuration { get { return _jumpDuration; } }
    public float JumpCooldown { get { return _jumpCooldown; } }
    public float DashPower { get { return _dashPower; } }
    public float DashDuration { get { return _dashDuration; } }
    public float DashCooldown { get { return _dashCooldown; } }
    public float OriginalGravity { get { return _originalGravity; } set { _originalGravity = value; } }

    public string CurrentIdle { get { return _currentIdle; } }
    public string Idle_Normal { get { return _idle_StrAnim[0]; } }
    public string Idle_Magical { get { return _idle_StrAnim[1]; } }
    public string Idle_Knight { get { return _idle_StrAnim[2]; } }
    public string Idle_NanoMachine { get { return _idle_StrAnim[3]; } }
    public string Idle_LimitBreak { get { return _idle_StrAnim[4]; } }

    public string CurrentRunS { get { return _currentRunS; } }
    public string RunS_Normal { get { return _runS_StrAnim[0]; } }
    public string RunS_Magical { get { return _runS_StrAnim[1]; } }
    public string RunS_Knight { get { return _runS_StrAnim[2]; } }
    public string RunS_NanoMachine { get { return _runS_StrAnim[3]; } }
    public string RunS_LimitBreak { get { return _runS_StrAnim[4]; } }

    public string CurrentRunN { get { return _currentRunN; } }
    public string RunN_Normal { get { return _runN_StrAnim[0]; } }
    public string RunN_Magical { get { return _runN_StrAnim[1]; } }
    public string RunN_Knight { get { return _runN_StrAnim[2]; } }
    public string RunN_NanoMachine { get { return _runN_StrAnim[3]; } }
    public string RunN_LimitBreak { get { return _runN_StrAnim[4]; } }

    public string CurrentRunE { get { return _currentRunE; } }
    public string RunE_Normal { get { return _runE_StrAnim[0]; } }
    public string RunE_Magical { get { return _runE_StrAnim[1]; } }
    public string RunE_Knight { get { return _runE_StrAnim[2]; } }
    public string RunE_NanoMachine { get { return _runE_StrAnim[3]; } }
    public string RunE_LimitBreak { get { return _runE_StrAnim[4]; } }

    public string CurrentJumpS { get { return _currentJumpS; } }
    public string JumpS_Normal { get { return _jumpS_StrAnim[0]; } }
    public string JumpS_Magical { get { return _jumpS_StrAnim[1]; } }
    public string JumpS_Knight { get { return _jumpS_StrAnim[2]; } }
    public string JumpS_NanoMachine { get { return _jumpS_StrAnim[3]; } }
    public string JumpS_LimitBreak { get { return _jumpS_StrAnim[4]; } }

    public string CurrentJumpN { get { return _currentJumpN; } }
    public string JumpN_Knight { get { return _jumpN_StrAnim[0]; } }

    public string CurrentFallS { get { return _currentFallS; } }
    public string FallS_Normal { get { return _fallS_StrAnim[0]; } }
    public string FallS_Magical { get { return _fallS_StrAnim[1]; } }
    public string FallS_Knight { get { return _fallS_StrAnim[2]; } }
    public string FallS_NanoMachine { get { return _fallS_StrAnim[3]; } }
    public string FallS_LimitBreak { get { return _fallS_StrAnim[4]; } }

    public string CurrentFallN { get { return _currentFallN; } }
    public string FallN_Normal { get { return _fallN_StrAnim[0]; } }
    public string FallN_Magical { get { return _fallN_StrAnim[1]; } }
    public string FallN_Knight { get { return _fallN_StrAnim[2]; } }
    public string FallN_NanoMachine { get { return _fallN_StrAnim[3]; } }
    public string FallN_LimitBreak { get { return _fallN_StrAnim[4]; } }

    public string CurrentFallE { get { return _currentFallE; } }
    public string FallE_Normal { get { return _fallE_StrAnim[0]; } }
    public string FallE_Magical { get { return _fallE_StrAnim[1]; } }
    public string FallE_Knight { get { return _fallE_StrAnim[2]; } }
    public string FallE_NanoMachine { get { return _fallE_StrAnim[3]; } }
    public string FallE_LimitBreak { get { return _fallE_StrAnim[4]; } }

    public string CurrentDash { get { return _currentDash; } }
    public string Dash_Normal { get { return _dash_StrAnim[0]; } }
    public string Dash_Magical { get { return _dash_StrAnim[1]; } }
    public string Dash_Knight { get { return _dash_StrAnim[2]; } }


    public bool SuperDashLock { get { return _superDashLock; } set { _superDashLock = value; } }
    public string SuperDashS_NanoMachine { get { return _dash_StrAnim[3]; } }
    public string SuperDashN_NanoMachine { get { return _dash_StrAnim[4]; } }
    public string SuperDashE_NanoMachine { get { return _dash_StrAnim[5]; } }

    public bool AirDashAtkLock { get { return _airDashAtkLock; } set { _airDashAtkLock = value; } }

    public bool DashAtkLock { get { return _dashAtkLock; } set { _dashAtkLock = value; } }
    public string DashAtk_LimitBreak { get { return _dash_StrAnim[6]; } }
    public string PerfectDash_LimitBreak { get { return _dash_StrAnim[7]; } }

    public bool AirDashLock { get { return _airDashLock; } set { _airDashLock = value; } }
    public string CurrentAirDash { get { return _currentAirDash; } }
    public string AirDash_Magical { get { return _airDash_StrAnim[0]; } }
    public string AirDash_Knight { get { return _airDash_StrAnim[1]; } }

    public bool AirSuperDashLock { get { return _airSuperDashLock; } set { _airSuperDashLock = value; } }
    public string AirSuperDashS_NanoMachine { get { return _airDash_StrAnim[2]; } }
    public string AirSuperDashN_NanoMachine { get { return _airDash_StrAnim[3]; } }
    public string AirSuperDashE_NanoMachine { get { return _airDash_StrAnim[4]; } }

    public string AirDashAtk_LimitBreak { get { return _airDash_StrAnim[5]; } }

    public bool AirLAtkLock { get { return _airLAtkLock; } set { _airLAtkLock = value; } }
    public string CurrentAirLAtk { get { return _currentAirLAtk; } }
    public string AirLAtk_Magical { get { return _airLAtk_StrAnim[0]; } }
    public string AirLAtk_Knight { get { return _airLAtk_StrAnim[1]; } }
    public string AirLAtk_NanoMachine { get { return _airLAtk_StrAnim[2]; } }

    public bool AirRAtkLock { get { return _airRAtkLock; } set { _airRAtkLock = value; } }
    public string CurrentAirRAtk { get { return _currentAirRAtk; } }
    public string AirRAtk_Magical { get { return _airRAtk_StrAnim[0]; } }
    public string AirRAtk_NanoMachine { get { return _airRAtk_StrAnim[1]; } }

    public bool LAtkLock { get { return _lAtkLock; } set { _lAtkLock = value; } }
    public string CurrentLAtkS { get { return _currentLAtkS; } }
    public string LAtkS_Magical { get { return _lAtk_StrAnim[0]; } }
    public string LAtkS_Knight { get { return _lAtk_StrAnim[2]; } }
    public string LAtkS_NanoMachine { get { return _lAtk_StrAnim[3]; } }
    public string LAtkS_LimitBreak { get { return _lAtk_StrAnim[4]; } }

    public string CurrentLAtkN { get { return _currentLAtkN; } }
    public string LAtkN_Magical { get { return _lAtk_StrAnim[1]; } }

    public bool RAtkLock { get { return _rAtkLock; } set { _rAtkLock = value; } }
    public string CurrentRAtk { get { return _currentRAtk; } }
    public string RAtkS_Magical { get { return _rAtk_StrAnim[0]; } }
    public string RAtkS_Knight { get { return _rAtk_StrAnim[1]; } }
    public string RAtkS_NanoMachine { get { return _rAtk_StrAnim[2]; } }
    public string RAtkS_LimitBreak { get { return _rAtk_StrAnim[3]; } }

    public bool ULAtkLock { get { return _uLAtkLock; } set { _uLAtkLock = value; } }
    public string CurrentULAtk { get { return _currentULAtk; } }
    public string ULAtkS_Magical { get { return _uLAtk_StrAnim[0]; } }
    public string ULAtkS_Knight { get { return _uLAtk_StrAnim[1]; } }

    public bool URAtkLock { get { return _uRAtkLock; } set { _uRAtkLock = value; } }

    public bool DLAtkLock { get { return _dLAtkLock; } set { _dLAtkLock = value; } }
    public string CurrentDLAtkS { get { return _currentDLAtkS; } }
    public string DLAtkS_Magical { get { return _dLAtk_StrAnim[0]; } }
    public string DLAtkS_Knight { get { return _dLAtk_StrAnim[1]; } }
    public string DLAtkS_NanoMachine { get { return _dLAtk_StrAnim[4]; } }

    public string CurrentDLAtkN { get { return _currentDLAtkN; } }
    public string DLAtkN_Knight { get { return _dLAtk_StrAnim[2]; } }

    public string CurrentDLAtkE { get { return _currentDLAtkE; } }
    public string DLAtkE_Knight { get { return _dLAtk_StrAnim[3]; } }

    public bool DRAtkLock { get { return _dRAtkLock; } set { _dRAtkLock = value; } }
    public string CurrentDRAtkS { get { return _currentDRAtkS; } }
    public string DRAtkS_Magical { get { return _dRAtk_StrAnim[0]; } }
    public string DRAtkS_Knight { get { return _dRAtk_StrAnim[3]; } }
    public string DRAtkS_NanoMachine { get { return _dRAtk_StrAnim[6]; } }
    public string DRAtkS_LimitBreak { get { return _dRAtk_StrAnim[7]; } }

    public string CurrentDRAtkN { get { return _currentDRAtkN; } }
    public string DRAtkN_Magical { get { return _dRAtk_StrAnim[1]; } }
    public string DRAtkN_Knight { get { return _dRAtk_StrAnim[4]; } }
    public string DRAtkN_LimitBreak { get { return _dRAtk_StrAnim[8]; } }

    public string CurrentDRAtkE { get { return _currentDRAtkE; } }
    public string DRAtkE_Magical { get { return _dRAtk_StrAnim[2]; } }
    public string DRAtkE_Knight { get { return _dRAtk_StrAnim[5]; } }
    public string DRAtkE_LimitBreak { get { return _dRAtk_StrAnim[9]; } }

    public bool WallGrabLock { get { return _wallGrabLock; } set { _wallGrabLock = value; } }
    public string WallGrabS_Knight { get { return _wallGrab_StrAnim[0]; } }
    public string WallGrabN_Knight { get { return _wallGrab_StrAnim[1]; } }
    public string WallGrabE_Knight { get { return _wallGrab_StrAnim[2]; } }

    public string AutoLimit_LimitBreak { get { return _intoLimit_StrAnim[0]; } }
    public string Limit_LimitBreak { get { return _intoLimit_StrAnim[1]; } }

    public string LimitOff_LimitBreak { get { return _outLimit_StrAnim[0]; } }
    public string OutLimit_LimitBreak { get { return _outLimit_StrAnim[1]; } }

    public string AirOutLimitS_LimitBreak { get { return _outLimit_StrAnim[2]; } }
    public string AirOutLimitN_LimitBreak { get { return _outLimit_StrAnim[3]; } }
    public string AirOutLimitE_LimitBreak { get { return _outLimit_StrAnim[4]; } }

    // Gravity variables
    float _gravity = -9.8f;
    float _originalGravity;

    // Player stat variables
    float _hp;
    float _mana;
    float _junibyou;
    float _damaged;

    // Idle variables
    bool _isIdle;

    // Run variables
    bool _isRun;
    bool _isRunPressed;
    float _moveSpeed;

    // Jump variables
    bool _isJump;
    bool _isFall;
    bool _isJumpPressed;
    float _jumpPower;
    float _jumpDuration;
    float _jumpCooldown;

    // Dash variables
    bool _isDash;
    bool _isDashPressed;
    float _dashPower;
    float _dashDuration;
    float _dashCooldown;

    // Air dash variables
    bool _isAirDash;
    bool _airDashLock;

    // Super Dash variables
    bool _isSuperDash;
    bool _superDashLock;
    bool _airSuperDashLock;

    // Dash attack variables
    bool _isDashAtk;
    bool _dashAtkLock;
    bool _airDashAtkLock;

    // Attack variables
    bool _isLAtk;
    bool _isLAtkPressed;
    bool _lAtkLock;

    bool _isRAtk;
    bool _isRAtkPressed;
    bool _rAtkLock;

    bool _isULAtk;
    bool _isULAtkPressed;
    bool _uLAtkLock;

    bool _isURAtk;
    bool _isURAtkPressed;
    bool _uRAtkLock;

    bool _isDLAtk;
    bool _isDLAtkPressed;
    bool _dLAtkLock;

    bool _isDRAtk;
    bool _isDRAtkPressed;
    bool _dRAtkLock;

    bool _isAirLAtk;
    bool _airLAtkLock;

    bool _isAirRAtk;
    bool _airRAtkLock;

    float _minDamage;
    float _maxDamage;

    bool _isChargeAtk;
    bool _chargeLock;
    float _minCharge;
    float _normalCharge;
    float _maxCharge;

    float _minLenght;
    float _normalLenght;
    float _maxLenght;

    // Wall grab
    bool _isWallGrab;
    bool _wallGrabLock;

    // Mana variables
    float _manaUsed;
    float _manaFill;

    // Junibyou variables
    float _junibyouFill;

    // Soul variables
    float _soul;

    // Accessorie variables
    bool _isAccessoriePressed;

    // Interact variables
    bool _isInteractPressed;

    // Map variables
    bool _isMapPressed;

    // Upgrade variables
    bool _isUpgradePressed;

    // Form variables
    bool _isNormalForm;
    bool _isNormalPressed;

    bool _isMagicalForm;
    bool _isMagicalPressed;

    bool _isKnightForm;
    bool _isKnightPressed;

    bool _isNanoMachineForm;
    bool _isNanoMachinePressed;

    bool _isLimitBreakForm;
    bool _isLimitBreakPressed;

    // Variables to store animation names
    string _currentIdle;
    string[] _idle_StrAnim = { "Idle_Normal", "Idle_Magical", "Idle_Knight", "Idle_NanoMachine", "Idle_LimitBreak" };

    string _currentRunS;
    string[] _runS_StrAnim = { "RunS_Normal", "RunS_Magical", "RunS_Knight", "RunS_NanoMachine", "RunS_LimitBreak" };

    string _currentRunN;
    string[] _runN_StrAnim = { "RunN_Normal", "RunN_Magical", "RunN_Knight", "RunN_NanoMachine", "RunN_LimitBreak" };

    string _currentRunE;
    string[] _runE_StrAnim = { "RunE_Normal", "RunE_Magical", "RunE_Knight", "RunE_NanoMachine", "RunE_LimitBreak" };

    string _currentJumpS;
    string[] _jumpS_StrAnim = { "JumpS_Normal", "JumpS_Magical", "JumpS_Knight", "JumpS_NanoMachine", "JumpS_LimitBreak" };

    string _currentJumpN;
    string[] _jumpN_StrAnim = { "JumpN_Knight" };

    string _currentFallS;
    string[] _fallS_StrAnim = { "FallS_Normal", "FallS_Magical", "FallS_Knight", "FallS_NanoMachine", "FallS_LimitBreak" };

    string _currentFallN;
    string[] _fallN_StrAnim = { "FallN_Normal", "FallN_Magical", "FallN_Knight", "FallN_NanoMachine", "FallN_LimitBreak" };

    string _currentFallE;
    string[] _fallE_StrAnim = { "FallE_Normal", "FallE_Magical", "FallE_Knight", "FallE_NanoMachine", "FallE_LimitBreak" };

    string _currentDash;
    string[] _dash_StrAnim = { "Dash_Normal", "Dash_Magical", "Dash_Knight", "SuperDashS_NanoMachine", "SuperDashN_NanoMachine", "SuperDashE_NanoMachine", "DashAtk_LimitBreak", "PerfectDash_LimitBreak" };

    string _currentAirDash;
    string[] _airDash_StrAnim = { "AirDash_Magical", "AirDash_Knight", "AirSuperDashS_NanoMachine", "AirSuperDashN_NanoMachine", "AirSuperDashE_NanoMachine", "AirDashAtk_LimitBreak" };

    string _currentAirLAtk;
    string[] _airLAtk_StrAnim = { "AirAtk_Magical", "AirAtk_Knight", "AirAtk_NanoMachine" };

    string _currentAirRAtk;
    string[] _airRAtk_StrAnim = { "AirSS_Magical", "AirCanon_NanoMachine" };

    string _currentLAtkS;
    string _currentLAtkN;
    string[] _lAtk_StrAnim = { "BasicAtk1_Magical", "BasicAtk2_Magical", "TpHitAtk_Knight", "SaberCombo_NanoMachine", "AirPunch_LimitBreak" };

    string _currentRAtk;
    string[] _rAtk_StrAnim = { "SuperShot_Magical", "StrikeStap_Knight", "ShotGunAuto_NanoMachine", "Combo_LimitBreak" };

    string _currentULAtk;
    string[] _uLAtk_StrAnim = { "AreaShot_Magical", "HighUp_Knight" };

    string _currentURAtk;
    string[] _uRAtk_StrAnim = { "" };

    string _currentDLAtkS;
    string _currentDLAtkN;
    string _currentDLAtkE;
    string[] _dLAtk_StrAnim = { "FireSpins_Magical", "SmashS_Kinght", "SmashN_Kinght", "SmashE_Kinght", "Trapmine_NanoMachine" };

    string _currentDRAtkS;
    string _currentDRAtkN;
    string _currentDRAtkE;
    string[] _dRAtk_StrAnim = { "BombAtkS_Magical", "BombAtkN_Magical", "BombAtkE_Magical", "CounterS_Knight", "CounterN_Knight", "CounterE_Knight", "SuperCanon_NanoMachine", "KamehamehaS_LimitBreak", "KamehamehaN_LimitBreak", "KamehamehaE_LimitBreak" };

    string[] _wallGrab_StrAnim = { "WallGrabS_Knight", "WallGrabN_Knight", "WallGrabE_Knight" };

    string[] _intoLimit_StrAnim = { "AutoLimit_LimitBreak", "Limit_LimitBreak" };
    string[] _outLimit_StrAnim = { "LimitOff_LimitBreak", "OutLimit_LimitBreak", "AirOutLimitS_LimitBreak", "AirOutLimitN_LimitBreak", "AirOutLimitE_LimitBreak", };

    private void OnEnable()
    {
        _input.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _input.Gameplay.Disable();
    }

    private void Awake()
    {
        // Initially set reference variables
        _input = new InputMap();
        _anim = GetComponent<Animator>();

        // Set parameter reference
        _moveSpeed = _marikaStat.MoveSpeed;

        _jumpPower = _marikaStat.JumpPower;
        _jumpDuration = _marikaStat.JumpDuration;
        _jumpCooldown = _marikaStat.JumpCooldown;

        _dashPower = _marikaStat.DashPower;
        _dashDuration = _marikaStat.DashDuration;
        _dashCooldown = _marikaStat.DashCooldown;

        // Set player input callbacks
        _input.Gameplay.Move.performed += OnMove;
        _input.Gameplay.Move.canceled += ExitMove;

        _input.Gameplay.Jump.performed += OnJump;
        _input.Gameplay.Jump.canceled += ExitJump;

        _input.Gameplay.Dash.performed += OnDash;
        _input.Gameplay.Dash.canceled += ExitDash;

        _input.Gameplay.LAtk.performed += OnLAtk;
        _input.Gameplay.LAtk.canceled += ExitLAtk;

        _input.Gameplay.RAtk.performed += OnRAtk;
        _input.Gameplay.RAtk.canceled += ExitRAtk;

        _input.Gameplay.ULAtk.performed += OnULAtk;
        _input.Gameplay.ULAtk.canceled += ExitULAtk;

        _input.Gameplay.URAtk.performed += OnURAtk;
        _input.Gameplay.URAtk.canceled += ExitURAtk;

        _input.Gameplay.DLAtk.performed += OnDLAtk;
        _input.Gameplay.DLAtk.canceled += ExitDLAtk;

        _input.Gameplay.DRAtk.performed += OnDRAtk;
        _input.Gameplay.DRAtk.canceled += ExitDRAtk;

        _input.Gameplay.Interact.performed += OnInteract;
        _input.Gameplay.Interact.canceled += ExitInteract;

        _input.Gameplay.Map.performed += OnMap;
        _input.Gameplay.Map.canceled += ExitMap;

        _input.Gameplay.Upgrade.performed += OnUpgrade;
        _input.Gameplay.Upgrade.canceled += ExitUpgrade;

        _input.Gameplay.Accessorie.performed += OnAccessorie;
        _input.Gameplay.Accessorie.canceled += ExitAccessorie;

        _input.Gameplay.NormalForm.performed += OnNormal;
        _input.Gameplay.NormalForm.canceled += ExitNormal;

        _input.Gameplay.MagicalForm.performed += OnMagical;
        _input.Gameplay.MagicalForm.canceled += ExitMagical;

        _input.Gameplay.KnightForm.performed += OnKnight;
        _input.Gameplay.KnightForm.canceled += ExitKnight;

        _input.Gameplay.NanoMachineForm.performed += OnNanoMachine;
        _input.Gameplay.NanoMachineForm.canceled += ExitNanoMachine;

        _input.Gameplay.LimitBreakForm.performed += OnLimitBreak;
        _input.Gameplay.LimitBreakForm.canceled += ExitLimitBreak;

        // Setup state
        _state = new Player_StateFactory(this);

        SetAnimIdle();
        _currentState = _state.Idle();
        _currentState.EnterState();
    }

    private void Update()
    {
        PointCheck();
        FlipSprite();
        _currentState.UpdateStates();
    }

    private void FixedUpdate()
    {
        _currentState.FixedUpdateStates();
    }

    public void PointCheck()
    {
        _isGround = Physics2D.OverlapCircle(_groundCheck.position, 0.1f, _groundLayer);

        _isWall = Physics2D.OverlapCircle(_wallCheck.position, 0.2f, _groundLayer);
    }

    private void OnDrawGizmos()
    {
        // Check ground
        if (_isGround)
        {
            Gizmos.color = Color.green;
        }
        else if (!_isGround)
        {
            Gizmos.color = Color.yellow;
        }

        Gizmos.DrawRay(_groundCheck.position, Vector3.down);

        // Check wall
        if (_facingRight)
        {
            Vector3 rightPos = _wallCheck.position + new Vector3(1f, 0f, 0f);

            if (_isWall)
            {
                Gizmos.color = Color.green;
            }
            else if (_isWall)
            {
                Gizmos.color = Color.red;
            }

            Gizmos.DrawLine(_wallCheck.position, rightPos);
        }
        else
        {
            Vector3 leftPos = _wallCheck.position - new Vector3(1f, 0f, 0f);

            if (_isWall)
            {
                Gizmos.color = Color.green;
            }
            else if (!_isWall)
            {
                Gizmos.color = Color.red;
            }

            Gizmos.DrawLine(_wallCheck.position, leftPos);
        }
    }

    // Flip player sprite
    public void FlipSprite()
    {
        if (_facingRight && _currentMoveInput.x < 0f || !_facingRight && _currentMoveInput.x > 0f)
        {
            Vector2 localScale = transform.localScale;
            _facingRight = !_facingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    // Falling physics
    public void FallingGravity()
    {
        if (_rb.velocity.y < 0f)
        {
            _rb.velocity += Vector2.up * (_gravity * Time.deltaTime);
        }
    }

    // Get animation lenght
    public float GetAnimLenght(string _animName)
    {
        if (_anim != null)
        {
            AnimationClip[] clips = _anim.runtimeAnimatorController.animationClips;

            foreach (AnimationClip clip in clips)
            {
                if (clip.name == _animName)
                {
                    return clip.length;
                }
            }
        }

        return 0f;
    }

    // Wait to change animation
    public void ChangeAnimation(string _animName)
    {
        _anim.Play(_animName);
    }

    public void HandleRun(float _speed)
    {
        _rb.velocity = new Vector2(_currentMoveInput.x * _speed * Time.deltaTime, _rb.velocity.y);
    }

    public void HandleJump(float _power)
    {
        _rb.velocity = Vector2.up * _power;
    }

    public void HandleDash(float _power)
    {
        _rb.velocity = new Vector2(_rb.transform.localScale.x * _power, 0f);
    }

    public void SetAnimIdle()
    {
        // Set variables animation names
        _currentIdle = Idle_Normal;

        _currentRunS = RunS_Normal;
        _currentRunN = RunN_Normal;
        _currentRunE = RunE_Normal;

        _currentJumpS = JumpS_Normal;
        _currentJumpN = null;

        _currentFallS = FallS_Normal;
        _currentFallN = FallN_Normal;
        _currentFallE = FallE_Normal;

        _currentDash = Dash_Normal;
        _currentAirDash = null;

        _currentAirLAtk = null;
        _currentAirRAtk = null;

        _currentLAtkS = null;
        _currentLAtkN = null;

        _currentRAtk = null;

        _currentULAtk = null;

        _currentDLAtkS = null;
        _currentDLAtkN = null;
        _currentDLAtkE = null;

        _currentDRAtkS = null;
        _currentDRAtkN = null;
        _currentDRAtkE = null;

        // Action lock
        _airDashLock = true;

        _airSuperDashLock = true;
        _superDashLock = true;

        _airDashAtkLock = true;
        _dashAtkLock = true;

        _airLAtkLock = true;
        _airRAtkLock = true;

        _lAtkLock = true;
        _rAtkLock = true;

        _uLAtkLock = true;
        _uRAtkLock = true;

        _dLAtkLock = true;
        _dRAtkLock = true;

        _wallGrabLock = true;
    }

    public void SetAnimMagical()
    {
        // Set variables animation names
        _currentIdle = Idle_Magical;

        _currentRunS = RunS_Magical;
        _currentRunN = RunN_Magical;
        _currentRunE = RunE_Magical;

        _currentJumpS = JumpS_Magical;
        _currentJumpN = null;

        _currentFallS = FallS_Magical;
        _currentFallN = FallN_Magical;
        _currentFallE = FallE_Magical;

        _currentDash = Dash_Magical;
        _currentAirDash = AirDash_Magical;

        _currentAirLAtk = AirLAtk_Magical;
        _currentAirRAtk = AirRAtk_Magical;

        _currentLAtkS = LAtkN_Magical;
        _currentLAtkN = LAtkN_Magical;

        _currentRAtk = RAtkS_Magical;

        _currentULAtk = ULAtkS_Magical;

        _currentDLAtkS = DLAtkS_Magical;
        _currentDLAtkN = null;
        _currentDLAtkE = null;

        _currentDRAtkS = DRAtkS_Magical;
        _currentDRAtkN = DRAtkN_Magical;
        _currentDRAtkE = DRAtkE_Magical;

        // Action lock
        _airDashLock = false;

        _airSuperDashLock = true;
        _superDashLock = true;

        _airDashAtkLock = true;
        _dashAtkLock = true;

        _airLAtkLock = false;
        _airRAtkLock = false;

        _lAtkLock = false;
        _rAtkLock = false;

        _uLAtkLock = false;
        _uRAtkLock = true;

        _dLAtkLock = false;
        _dRAtkLock = false;

        _wallGrabLock = true;
    }

    public void SetAnimKnight()
    {
        // Set variables animation names
        _currentIdle = Idle_Knight;

        _currentRunS = RunS_Knight;
        _currentRunN = RunN_Knight;
        _currentRunE = RunE_Knight;

        _currentJumpS = JumpS_Knight;
        _currentJumpN = JumpN_Knight;

        _currentFallS = FallS_Knight;
        _currentFallN = FallN_Knight;
        _currentFallE = FallE_Knight;

        _currentDash = Dash_Knight;
        _currentAirDash = AirDash_Knight;

        _currentAirLAtk = AirLAtk_Knight;
        _currentAirRAtk = null;

        _currentLAtkS = LAtkS_Knight;
        _currentLAtkN = null;

        _currentRAtk = RAtkS_Knight;

        _currentULAtk = ULAtkS_Knight;

        _currentDLAtkS = DLAtkS_Knight;
        _currentDLAtkN = DLAtkN_Knight;
        _currentDLAtkE = DLAtkE_Knight;

        _currentDRAtkS = DRAtkS_Knight;
        _currentDRAtkN = DRAtkN_Knight;
        _currentDRAtkE = DRAtkE_Knight;

        // Action lock
        _airDashLock = false;

        _airSuperDashLock = true;
        _superDashLock = true;

        _airDashAtkLock = true;
        _dashAtkLock = true;

        _airLAtkLock = false;
        _airRAtkLock = true;

        _lAtkLock = false;
        _rAtkLock = false;

        _uLAtkLock = false;
        _uRAtkLock = true;

        _dLAtkLock = false;
        _dRAtkLock = false;

        _wallGrabLock = false;
    }

    public void SetAnimNanoMachine()
    {
        // Set variables animation names
        _currentIdle = Idle_NanoMachine;

        _currentRunS = RunS_NanoMachine;
        _currentRunN = RunN_NanoMachine;
        _currentRunE = RunE_NanoMachine;

        _currentJumpS = JumpS_NanoMachine;
        _currentJumpN = null;

        _currentFallS = FallS_NanoMachine;
        _currentFallN = FallN_NanoMachine;
        _currentFallE = FallE_NanoMachine;

        _currentDash = null;
        _currentAirDash = null;

        _currentAirLAtk = AirLAtk_NanoMachine;
        _currentAirRAtk = AirRAtk_NanoMachine;

        _currentLAtkS = LAtkS_NanoMachine;
        _currentLAtkN = null;

        _currentRAtk = RAtkS_NanoMachine;

        _currentULAtk = null;

        _currentDLAtkS = DLAtkS_NanoMachine;
        _currentDLAtkN = null;
        _currentDLAtkE = null;

        _currentDRAtkS = DRAtkS_NanoMachine;
        _currentDRAtkN = null;
        _currentDRAtkE = null;

        // Action lock
        _airDashLock = false;

        _airSuperDashLock = false;
        _superDashLock = false;

        _airDashAtkLock = true;
        _dashAtkLock = true;

        _airLAtkLock = false;
        _airRAtkLock = true;

        _lAtkLock = false;
        _rAtkLock = false;

        _uLAtkLock = true;
        _uRAtkLock = true;

        _dLAtkLock = false;
        _dRAtkLock = false;

        _wallGrabLock = true;
    }

    public void SetAnimLimitBreak()
    {
        // Set variables animation names
        _currentIdle = Idle_LimitBreak;

        _currentRunS = RunS_LimitBreak;
        _currentRunN = RunN_LimitBreak;
        _currentRunE = RunE_LimitBreak;

        _currentJumpS = JumpS_LimitBreak;
        _currentJumpN = null;

        _currentFallS = FallS_LimitBreak;
        _currentFallN = FallN_LimitBreak;
        _currentFallE = FallE_LimitBreak;

        _currentDash = null;
        _currentAirDash = null;

        _currentAirLAtk = null;
        _currentAirRAtk = null;

        _currentLAtkS = LAtkS_LimitBreak;
        _currentLAtkN = null;

        _currentRAtk = RAtkS_LimitBreak;

        _currentULAtk = null;

        _currentDLAtkS = null;
        _currentDLAtkN = null;
        _currentDLAtkE = null;

        _currentDRAtkS = DRAtkS_LimitBreak;
        _currentDRAtkN = DRAtkN_LimitBreak;
        _currentDRAtkE = DRAtkE_LimitBreak;

        // Action lock
        _airDashLock = false;

        _airSuperDashLock = true;
        _superDashLock = true;

        _airDashAtkLock = false;
        _dashAtkLock = false;

        _airLAtkLock = true;
        _airRAtkLock = true;

        _lAtkLock = false;
        _rAtkLock = false;

        _uLAtkLock = true;
        _uRAtkLock = true;

        _dLAtkLock = true;
        _dRAtkLock = false;

        _wallGrabLock = true;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _currentMoveInput = _input.Gameplay.Move.ReadValue<Vector2>();
        _isRunPressed = _currentMoveInput.x != _zero.x;

        // Check console
        Debug.Log($"isRun : {_isRunPressed}");
    }

    private void ExitMove(InputAction.CallbackContext context)
    {
        _currentMoveInput = _zero;
        _isRunPressed = false;

        // Check console
        Debug.Log($"isRun : {_isRunPressed}");
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        _jumpPower = _marikaStat.JumpPower;
        _isJumpPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isJump : {_isJumpPressed}");
    }

    private void ExitJump(InputAction.CallbackContext context)
    {
        _isJumpPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isJump : {_isJumpPressed}");
    }

    private void OnDash(InputAction.CallbackContext context)
    {
        _dashPower = _marikaStat.DashPower;
        _isDashPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isDash : {_isDashPressed}");
    }

    private void ExitDash(InputAction.CallbackContext context)
    {
        _dashPower = 0f;
        _isDashPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isDash : {_isDashPressed}");
    }

    private void OnLAtk(InputAction.CallbackContext context)
    {
        _isLAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isLAtk : {_isLAtkPressed}");
    }

    private void ExitLAtk(InputAction.CallbackContext context)
    {
        _isLAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isLAtk : {_isLAtkPressed}");
    }

    private void OnRAtk(InputAction.CallbackContext context)
    {
        _isRAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isRAtk : {_isRAtkPressed}");
    }

    private void ExitRAtk(InputAction.CallbackContext context)
    {
        _isRAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isRAtk : {_isRAtkPressed}");
    }

    private void OnULAtk(InputAction.CallbackContext context)
    {
        _isULAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isULAtk : {_isULAtkPressed}");
    }

    private void ExitULAtk(InputAction.CallbackContext context)
    {
        _isULAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isULAtk : {_isULAtkPressed}");
    }

    private void OnURAtk(InputAction.CallbackContext context)
    {
        _isURAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isURAtk : {_isURAtkPressed}");
    }

    private void ExitURAtk(InputAction.CallbackContext context)
    {
        _isURAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isURAtk : {_isURAtkPressed}");
    }

    private void OnDLAtk(InputAction.CallbackContext context)
    {
        _isDLAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isDLAtk : {_isDLAtkPressed}");
    }

    private void ExitDLAtk(InputAction.CallbackContext context)
    {
        _isDLAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isDLAtk : {_isDLAtkPressed}");
    }

    private void OnDRAtk(InputAction.CallbackContext context)
    {
        _isDRAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isDRAtk : {_isDRAtkPressed}");
    }

    private void ExitDRAtk(InputAction.CallbackContext context)
    {
        _isDRAtkPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isDRAtk : {_isDRAtkPressed}");
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        _isInteractPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isInteract : {_isInteractPressed}");
    }

    private void ExitInteract(InputAction.CallbackContext context)
    {
        _isInteractPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isInteract : {_isInteractPressed}");
    }

    private void OnMap(InputAction.CallbackContext context)
    {
        _isMapPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isMap : {_isMapPressed}");
    }

    private void ExitMap(InputAction.CallbackContext context)
    {
        _isMapPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isMap : {_isMapPressed}");
    }

    private void OnUpgrade(InputAction.CallbackContext context)
    {
        _isUpgradePressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isUpgrade : {_isUpgradePressed}");
    }

    private void ExitUpgrade(InputAction.CallbackContext context)
    {
        _isUpgradePressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isUpgrade : {_isUpgradePressed}");
    }

    private void OnAccessorie(InputAction.CallbackContext context)
    {
        _isAccessoriePressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isAccessorie : {_isAccessoriePressed}");
    }

    private void ExitAccessorie(InputAction.CallbackContext context)
    {
        _isAccessoriePressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isAccessorie : {_isAccessoriePressed}");
    }

    private void SetFormVariable()
    {
        switch (_form)
        {
            case 1:
                SetAnimIdle();
                break;
            case 2:
                SetAnimMagical();
                break;
            case 3:
                SetAnimKnight();
                break;
            case 4:
                SetAnimNanoMachine();
                break;
            case 5:
                SetAnimLimitBreak();
                break;
        }

        _currentState.EnterState();
    }

    private void OnNormal(InputAction.CallbackContext context)
    {
        _isNormalPressed = context.ReadValueAsButton();
        _form = 1;
        SetFormVariable();

        // Check console
        Debug.Log($"isNormal : {_isNormalPressed}");
    }

    private void ExitNormal(InputAction.CallbackContext context)
    {
        _isNormalPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isNormal : {_isNormalPressed}");
    }

    private void OnMagical(InputAction.CallbackContext context)
    {
        _isMagicalPressed = context.ReadValueAsButton();
        _form = 2;
        SetFormVariable();

        // Check console
        Debug.Log($"isMagical : {_isMagicalPressed}");
    }

    private void ExitMagical(InputAction.CallbackContext context)
    {
        _isMagicalPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isMagical : {_isMagicalPressed}");
    }

    private void OnKnight(InputAction.CallbackContext context)
    {
        _isKnightPressed = context.ReadValueAsButton();
        _form = 3;
        SetFormVariable();

        // Check console
        Debug.Log($"isKnight : {_isKnightPressed}");
    }

    private void ExitKnight(InputAction.CallbackContext context)
    {
        _isKnightPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isKnight : {_isKnightPressed}");
    }

    private void OnNanoMachine(InputAction.CallbackContext context)
    {
        _isNanoMachinePressed = context.ReadValueAsButton();
        _form = 4;
        SetFormVariable();

        // Check console
        Debug.Log($"isNanoMachine : {_isNanoMachinePressed}");
    }

    private void ExitNanoMachine(InputAction.CallbackContext context)
    {
        _isNanoMachinePressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isNanoMachine : {_isNanoMachinePressed}");
    }

    private void OnLimitBreak(InputAction.CallbackContext context)
    {
        _isLimitBreakPressed = context.ReadValueAsButton();
        _form = 5;
        SetFormVariable();

        // Check console
        Debug.Log($"isLimitBreak : {_isLimitBreakPressed}");
    }

    private void ExitLimitBreak(InputAction.CallbackContext context)
    {
        _isLimitBreakPressed = context.ReadValueAsButton();

        // Check console
        Debug.Log($"isLimitBreak : {_isLimitBreakPressed}");
    }
}