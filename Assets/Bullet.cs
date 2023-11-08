using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public float lifeTime = 2;
    public GameObject piece;

    void Start()
    {
        Destroy(gameObject,lifeTime);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.tag != "Destructible")
        {
            return;

        }
        for (int i = 0; i < 20; i++)
        {
            var offset = Random.insideUnitSphere;
            Instantiate(piece, transform.position + offset, transform.rotation);

        }
        Destroy(collision.gameObject);
    }
}