using UnityEngine;

public class PlayerAnimationEventHandler : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem jumpEffect;

    public void PlayJumpEffect()
    {
        jumpEffect.Play();
    }
}