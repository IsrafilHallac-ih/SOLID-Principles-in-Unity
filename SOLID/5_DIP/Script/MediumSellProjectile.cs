using UnityEngine;

public class MediumSellProjectile : MonoBehaviour, IProjectile
{
    public GameObject shellPrefab;
    public void Fire(Transform firePoint)
    {
        GameObject shell = GameObject.Instantiate(shellPrefab, firePoint.position, firePoint.rotation);
        shell.GetComponent<Rigidbody2D>().AddForce(firePoint.up * 10f, ForceMode2D.Impulse);
    }
}
