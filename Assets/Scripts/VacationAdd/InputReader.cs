using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

[CreateAssetMenu(menuName = "InputReader")]
public class InputReader : ScriptableObject, PlayerActionMaps.IPlayerActions, PlayerActionMaps.ITestingActions
{
    //player event
    public event Action InteractEvent;
    public event Action<Vector2> MoveEvent;
    public event Action<InputActionPhase> RunEvent;
    public event Action<Quaternion> VRLookEvent;
    public event Action ReplayEvent;
    public event Action TurnLightOff;
    //testing event
    public event Action<InputActionPhase> SpacePressed;


    PlayerActionMaps playerActionMaps;
    void OnEnable()
    {
        if (playerActionMaps == null)
        {
            playerActionMaps = new PlayerActionMaps();
            playerActionMaps.Player.SetCallbacks(this);
            playerActionMaps.Testing.SetCallbacks(this);
        }
        playerActionMaps.Player.Enable();
        playerActionMaps.Testing.Enable();
        Debug.Log("OnEnable");
    }
    void OnDisable()
    {
        playerActionMaps.Player.Disable();
        playerActionMaps.Testing.Disable();
        Debug.Log("Disable");
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            InteractEvent?.Invoke();
        }
    }

    //Player
    public void OnLook(InputAction.CallbackContext context)
    {
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }


    public void OnRun(InputAction.CallbackContext context)
    {
        RunEvent?.Invoke(context.phase);
    }

    public void OnVRInteract(InputAction.CallbackContext context)
    {
    }

    public void OnVRLook(InputAction.CallbackContext context)
    {
        VRLookEvent?.Invoke(context.ReadValue<Quaternion>());
    }

    //Testing
    public void OnReplay(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            ReplayEvent?.Invoke();
        }
    }
    public void OnSpace(InputAction.CallbackContext context)
    {
        SpacePressed?.Invoke(context.phase);
    }
    public void OnLightOff(InputAction.CallbackContext context)
    {
        TurnLightOff?.Invoke();
    }
}
