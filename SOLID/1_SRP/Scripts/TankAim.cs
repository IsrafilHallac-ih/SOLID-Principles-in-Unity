using UnityEngine;

public class TankAim : MonoBehaviour
{
    public Transform aimRotationObject;

    // Update is called once per frame
    void Update()
    {
        Aim();
    }

    void Aim()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        aimRotationObject.rotation = Quaternion.Euler(0, 0, angle);
    }
}
