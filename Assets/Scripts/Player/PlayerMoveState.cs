using UnityEngine;

public class PlayerMoveState : State<Player>
{
    public override void Enter(Player entity)
    {
        // TODO : 애니메이션 재생
    }

    public override void Update(Player entity)
    {
        if (Input.GetKey(KeyCode.D))
        {
            entity.Rigidbody2D.MovePosition(entity.Rigidbody2D.position + Vector2.right * Time.deltaTime);
        }
        else
        {
            entity.StateMachine.ChangeState(entity.States[StateType.Idle]);
        }
    }

    public override void Exit(Player entity)
    {

    }
}