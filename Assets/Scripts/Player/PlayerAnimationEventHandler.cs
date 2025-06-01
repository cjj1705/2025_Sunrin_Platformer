using UnityEngine;

public class PlayerAnimationEventHandler : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem moveEffect;

    public void PlayMoveEffect()
    {
        moveEffect.Play();
    }
}