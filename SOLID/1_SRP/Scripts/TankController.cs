using UnityEngine;

public class TankController : MonoBehaviour
{
    public Transform movementObject;
    public Transform aimRotationObject;
    public float moveSpeed=5f;
    public float rotationSpeed = 10f;
    public GameObject bulletPrefabs;
    public Transform firePoint;
    public float bulletForce = 10f;

    private void Update()
    {
        Move();
        Aim();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Move()
    {
        float moveInput = Input.GetAxis("Vertical");
        movementObject.Translate(Vector2.up * moveInput * moveSpeed * Time.deltaTime);
    }

    void Aim()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        aimRotationObject.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefabs, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
