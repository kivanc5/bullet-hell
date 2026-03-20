using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour, IPoolManager
{
    [System.Serializable]
    public class Pool
    {
        public string key;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;

    private Dictionary<string, Queue<GameObject>> poolDictionary;

    void Awake()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.key, objectPool);
        }
    }

    public GameObject GetFromPool(string key, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(key))
        {
            Debug.LogWarning("Pool not found: " + key);
            return null;
        }

        GameObject obj = poolDictionary[key].Dequeue();

        obj.SetActive(true);
        obj.transform.position = position;
        obj.transform.rotation = rotation;

        IPoolable poolable = obj.GetComponent<IPoolable>();
        poolable?.OnSpawn();

        poolDictionary[key].Enqueue(obj);

        return obj;
    }

    public void ReturnToPool(string key, GameObject obj)
    {
        obj.SetActive(false);

        IPoolable poolable = obj.GetComponent<IPoolable>();
        poolable?.OnDespawn();
    }
}
