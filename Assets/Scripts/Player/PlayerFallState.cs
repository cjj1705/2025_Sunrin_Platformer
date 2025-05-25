using UnityEngine;

public class PlayerFallState : State<Player>
{
    public override void Enter(Player player)
    {
        player.Animator.SetTrigger("Fall");
    }

    public override void Update(Player player)
    {
        player.Rigidbody2D.linearVelocityX = PlayerInputManager.Instance.Move.ReadValue<Vector2>().x * player.PlayerData.MoveSpeed;

        if (player.Rigidbody2D.linearVelocityY <= 0f)
        {
            RaycastHit2D hit = Physics2D.Raycast(player.transform.position, Vector2.down, 0.1f, LayerMask.GetMask("Ground"));
            if (hit.collider != null)
            {
                player.StateMachine.ChangeState(player.States[StateType.Idle]);
            }
        }
    }

    public override void Exit(Player player)
    {
        player.Animator.ResetTrigger("Fall");
    }
}