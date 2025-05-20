using UnityEngine;

public class PlayerIdleState : State<Player>
{
    public override void Enter(Player player)
    {
        // TODO : 애니메이션 재생
    }

    public override void Update(Player player)
    {
        if (PlayerInputManager.Instance.Move.ReadValue<Vector2>().x != 0f)
        {
            player.StateMachine.ChangeState(player.States[StateType.Move]);
        }
    }

    public override void Exit(Player player)
    {

    }
}