using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    Vector2 movementInput;
    // Start is called before the first frame update
    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }
    //hi
}
