using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DesktopMovementControls : MovementControlsBase
{
    [SerializeField]
    float _deadZoneRadius = 0.2f;    

    Vector2 ScreenCenter => new Vector2(Screen.width*0.5f, Screen.height*0.5f);

    public override float YawAmount {
        get{
            if(Input.GetKey(KeyCode.A)){
                return -0.1f;
            } else if (Input.GetKey(KeyCode.D)) {
                return 0.1f;
            }
            return 0f;
        
        }
    }

    public override float PitchAmount {
        get {
            if(Input.GetKey(KeyCode.W)){
                return 0.1f;
            } else if (Input.GetKey(KeyCode.S)) {
                return -0.1f;
            }
            return 0f;
        }
    }
    public override float RollAmount {
        get {
            if (Input.GetKey(KeyCode.Q)) {
                return 0.1f;
            }
            return Input.GetKey(KeyCode.E) ? -0.1f : 0f;
        }
    }

    public override float ThrustAmount {
        get{
            if(Input.GetKey(KeyCode.LeftShift)){
                return 0.2f;
            } else if (Input.GetKey(KeyCode.LeftControl)) {
                return -0.2f;
            }   
            return 0f;
        }
    }

}
