using UnityEngine;

public class PlayerIdleState : State<Player>
{
    public override void Enter(Player entity)
    {
        // TODO : �ִϸ��̼� ���
    }

    public override void Update(Player entity)
    {
        // TODO : InputSystem ����
        if (Input.GetKey(KeyCode.D))
        {
            entity.StateMachine.ChangeState(entity.States[StateType.Move]);
        }
    }

    public override void Exit(Player entity)
    {

    }
}