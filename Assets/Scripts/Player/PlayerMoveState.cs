using UnityEngine;

public class PlayerMoveState : State<Player>
{
    public override void Enter(Player entity)
    {
        // TODO : 애니메이션 재생
    }

    public override void Update(Player entity)
    {
        if (PlayerInputManager.Instance.Move.ReadValue<Vector2>().x != 0f)
        {
            entity.Rigidbody2D.MovePosition(entity.Rigidbody2D.position +
                new Vector2(PlayerInputManager.Instance.Move.ReadValue<Vector2>().x, 0) * Time.deltaTime);
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