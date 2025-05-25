using UnityEngine;

public class PlayerMoveState : State<Player>
{
    private float moveInput;

    public override void Enter(Player player)
    {
        player.Animator.SetTrigger("Move");
    }

    public override void Update(Player player)
    {
        if (player.Rigidbody2D.linearVelocityY < 0f)
        {
            player.StateMachine.ChangeState(player.States[StateType.Fall]);
            return;
        }

        if (PlayerInputManager.Instance.Jump.IsPressed())
        {
            player.StateMachine.ChangeState(player.States[StateType.Jump]);
        }

        moveInput = PlayerInputManager.Instance.Move.ReadValue<Vector2>().x;

        if (moveInput != 0f)
        {
            player.Rigidbody2D.linearVelocityX = moveInput * player.PlayerData.MoveSpeed;
        }
        else
        {
            player.Rigidbody2D.linearVelocityX = 0f;
            player.StateMachine.ChangeState(player.States[StateType.Idle]);
        }
    }

    public override void Exit(Player player)
    {
        player.Animator.ResetTrigger("Move");
    }
}