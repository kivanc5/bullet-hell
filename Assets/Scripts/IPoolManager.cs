using UnityEngine;

public interface IPoolManager
{
    GameObject GetFromPool(string key, Vector3 position, Quaternion rotation);
    void ReturnToPool(string key, GameObject obj);
}
