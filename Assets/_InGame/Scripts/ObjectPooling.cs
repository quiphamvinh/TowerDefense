using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling instance;
    private Dictionary<string, Queue<GameObject>> poolDictionary;
    [System.Serializable]
    public class Pool
    {
        public string nametag;
        public GameObject prefab;
        public int size;
        public Transform parent;
    }
    public List<Pool> poolList;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        foreach (Pool pool in poolList)
        {
            Queue<GameObject> objPool = new Queue<GameObject>();
            for (int i = 0;i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                if (pool.parent != null)
                {
                    obj.transform.SetParent(pool.parent);
                }
                objPool.Enqueue(obj);
            }
            poolDictionary.Add(pool.nametag, objPool);
        }
    }
}
