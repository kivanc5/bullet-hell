using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public string poolKey = "Bullet";
    public float fireRate = 0.2f;

    private float lastFireTime;
    private IPoolManager poolManager;

    void Start()
    {
        poolManager = FindObjectOfType<PoolManager>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= lastFireTime)
        {
            Shoot();
            lastFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        poolManager.GetFromPool(poolKey, transform.position, transform.rotation);
    }
}