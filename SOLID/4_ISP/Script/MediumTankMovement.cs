using UnityEngine;

public class MediumTankMovement :TankMovement,IMoveForward
{
    public void MoveForward(float inputValue)
    {
        movementObject.Translate(Vector2.up * inputValue * moveSpeed * Time.deltaTime);
    }
}

    

