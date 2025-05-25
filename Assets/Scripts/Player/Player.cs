using System.Collections.Generic;
using UnityEngine;

public enum StateType
{
    Idle,
    Move,
    Jump,
    Fall
}

public class Player : MonoBehaviour
{
    #region FSM
    public Dictionary<StateType, State<Player>> States;
    public StateMachine<Player> StateMachine;
    #endregion

    #region Component
    [HideInInspector]
    public Rigidbody2D Rigidbody2D;
    [HideInInspector]
    public Animator Animator;
    #endregion

    public PlayerData PlayerData;

    private void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        States = new Dictionary<StateType, State<Player>>();
        StateMachine = new StateMachine<Player>();

        // 상태 추가
        States.Add(StateType.Idle, new PlayerIdleState());
        States.Add(StateType.Move, new PlayerMoveState());
        States.Add(StateType.Jump, new PlayerJumpState());
        States.Add(StateType.Fall, new PlayerFallState());

        StateMachine.Setup(this, States[StateType.Idle]);
    }

    private void Update()
    {
        StateMachine.Update();
    }
}