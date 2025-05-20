using UnityEngine;

public class PlayerIdleState : State<Player>
{
    public override void Enter(Player entity)
    {
        // TODO : 애니메이션 재생
    }

    public override void Update(Player entity)
    {
        if (PlayerInputManager.Instance.Move.ReadValue<Vector2>().x != 0f)
        {
            entity.StateMachine.ChangeState(entity.States[StateType.Move]);
        }
    }

    public override void Exit(Player entity)
    {

    }
}