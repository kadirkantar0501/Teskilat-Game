using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour
{
    public PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    private PlayerMotor motor;
    private PlayerLook look;
    
    
    private void Awake() {
        look = GetComponent<PlayerLook>();
        
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        onFoot.Jump.performed += ctx => motor.Jump();
        

        
    }

    
    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());

    }


    private void LateUpdate() {
        
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
        
        
    }

    private void OnEnable() {
        onFoot.Enable();
    }

    private void OnDisable() {
        onFoot.Disable();
        
    }
}
