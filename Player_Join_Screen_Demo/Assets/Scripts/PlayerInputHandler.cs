using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerConfiguration playerConfig;
    private Mover mover;

    [SerializeField]
    private MeshRenderer playerMesh;

    private PlayerControls controls;
    private void Start()
    {
        mover = GetComponent<Mover>();
        controls = new PlayerControls();
    }

    public void InitializePlayer(PlayerConfiguration config)
    {
        playerConfig = config;
        playerMesh.material = config.playerMaterial;
        config.Input.onActionTriggered += Input_onActionTriggered;
    }   

    private void Input_onActionTriggered(CallbackContext obj)
    {
        if (obj.action.name == controls.PlayerMovement.Movement.name)
        {
            OnMove(obj);
        }
    }

    public void OnMove(CallbackContext context)
    {
        if(mover != null)
            mover.SetInputVector(context.ReadValue<Vector2>());
    }

}
