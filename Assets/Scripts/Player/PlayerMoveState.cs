using UnityEngine;

public class PlayerMoveState : State<Player>
{
    public override void Enter(Player player)
    {
        // TODO : 애니메이션 재생
    }

    public override void Update(Player player)
    {
        if (PlayerInputManager.Instance.Move.ReadValue<Vector2>().x != 0f)
        {
            player.Rigidbody2D.MovePosition(player.Rigidbody2D.position +
                new Vector2(PlayerInputManager.Instance.Move.ReadValue<Vector2>().x, 0) * player.PlayerData.MoveSpeed * Time.deltaTime);
        }
        else
        {
            player.StateMachine.ChangeState(player.States[StateType.Idle]);
        }
    }

    public override void Exit(Player player)
    {

    }
}