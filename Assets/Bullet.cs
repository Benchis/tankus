using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public float lifeTime = 2;

    void Start()
    {
        Destroy(gameObject,lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}