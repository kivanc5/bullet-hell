using UnityEngine;

public class Bullet : MonoBehaviour, IPoolable
{
    public float speed = 10f;
    public float lifeTime = 2f;

    private float timer;

    public void OnSpawn()
    {
        timer = 0f;
    }

    public void OnDespawn()
    {
        
    }

    void Update()
    {
        Move();

        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            gameObject.SetActive(false);
        }
    }

    void Move()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
