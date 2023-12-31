using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    public float rotateSpeed = 90;

    public string horizontalAxis;
    public string verticalAxis;
    public KeyCode shootKey;

    public GameObject bullet;
    public Transform shootPoint;

    void Update()
    {
        var ver = Input.GetAxis(verticalAxis);
        transform.position += transform.forward * speed * ver * Time.deltaTime;

        var hor = Input.GetAxis(horizontalAxis);
        transform.Rotate(0,rotateSpeed * Time.deltaTime * hor,0);

        if (Input.GetKeyDown(shootKey))
        {
            print("Shoot");
            Instantiate(bullet,shootPoint.position,shootPoint.rotation);
        }
    }
}