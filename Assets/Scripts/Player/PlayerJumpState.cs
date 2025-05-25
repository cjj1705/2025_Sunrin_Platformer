using UnityEngine;

public class PlayerJumpState : State<Player>
{
    public override void Enter(Player player)
    {
        player.Animator.SetTrigger("Jump");

        player.Rigidbody2D.AddForce(Vector2.up * player.PlayerData.JumpForce, ForceMode2D.Impulse);
    }

    public override void Update(Player player)
    {
        player.Rigidbody2D.linearVelocityX = PlayerInputManager.Instance.Move.ReadValue<Vector2>().x * player.PlayerData.MoveSpeed;

        if (player.Rigidbody2D.linearVelocityY <= 0f)
        {
            player.StateMachine.ChangeState(player.States[StateType.Fall]);
        }
    }

    public override void Exit(Player player)
    {
        player.Animator.ResetTrigger("Jump");
    }
}