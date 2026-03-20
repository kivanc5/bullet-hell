using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{
    public string poolKey = "Bullet";
    public float fireRate = 0.2f;

    private IPoolManager poolManager;

    void Start()
    {
        poolManager = FindObjectOfType<PoolManager>();
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            poolManager.GetFromPool(poolKey, transform.position, transform.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
