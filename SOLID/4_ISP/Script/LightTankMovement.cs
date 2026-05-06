using UnityEngine;

public class LightTankMovement : TankMovement, IMoveForward, IMoveBackward
{
    public void MoveForward(float inputValue)
    {
        movementObject.Translate(Vector2.up *inputValue * moveSpeed * Time.deltaTime);
    }

    public void MoveBackward(float inputValue)
    {
        movementObject.Translate(Vector2.down * inputValue * moveSpeed * Time.deltaTime);

    }   
}
