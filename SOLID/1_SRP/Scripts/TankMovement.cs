using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public Transform movementObject;
    public float moveSpeed = 5f;
    
    void Update()
    {
        Move();
    }

   void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        movementObject.Translate(Vector2.up * moveInput * moveSpeed * Time.deltaTime);
    }
}
