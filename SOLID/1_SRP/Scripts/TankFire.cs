using UnityEngine;

public class TankFire : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public Transform firePoint;
    public float bulletForce = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
         Fire();
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefabs, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
