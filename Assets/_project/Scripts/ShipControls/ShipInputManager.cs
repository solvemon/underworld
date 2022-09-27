using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInputManager : MonoBehaviour
{
    public enum InputType {
        HumanDesktop,
        HumanMobile,
        Bot
    }

    public static IMovementControls GetInputControls(InputType inputType) {
        return inputType switch {
            InputType.HumanDesktop => new DesktopMovementControls(),
            InputType.HumanMobile => null,
            InputType.Bot => null,
            _ => throw new ArgumentOutOfRangeException(nameof(inputType), inputType, null)
        };
    }
}
