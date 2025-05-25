using UnityEngine;

public class PlayerIdleState : State<Player>
{
    public override void Enter(Player player)
    {
        player.Animator.SetTrigger("Idle");
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
        else if (PlayerInputManager.Instance.Move.ReadValue<Vector2>().x != 0f)
        {
            player.StateMachine.ChangeState(player.States[StateType.Move]);
        }
    }

    public override void Exit(Player player)
    {
        player.Animator.ResetTrigger("Idle");
    }
}