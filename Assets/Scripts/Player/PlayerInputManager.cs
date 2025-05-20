using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager Instance { get; private set; }

    private PlayerInputAction PlayerInputAction;

    [HideInInspector]
    public InputAction Move;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        PlayerInputAction = new PlayerInputAction();
        PlayerInputAction.Enable();

        Move = PlayerInputAction.Player.Move;
    }
}