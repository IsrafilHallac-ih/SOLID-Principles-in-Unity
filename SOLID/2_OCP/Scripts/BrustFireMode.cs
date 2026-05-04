using UnityEngine;

public class BrustFireMode:IFireMode
{
   public void Fire(Transform firePoint, GameObject bulletPrefabs)
    {
        float[] angles = { -15f, 0, 15f };
        foreach (var angle in angles)
        {
            Quaternion rotationForBullet = firePoint.rotation * Quaternion.Euler(0, 0, angle);
            GameObject bullet =GameObject.Instantiate(bulletPrefabs, firePoint.position, rotationForBullet);
            bullet.GetComponent<Rigidbody2D>().AddForce(bullet.transform.up * 15f, ForceMode2D.Impulse);
        }
    }
}
