using UnityEngine;

public class NormalFireMode : IFireMode
{


  public void Fire(Transform firePoint, GameObject bulletPrefabs)
    {
        GameObject bullet =GameObject.Instantiate(bulletPrefabs, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * 10f, ForceMode2D.Impulse);
    }
}
