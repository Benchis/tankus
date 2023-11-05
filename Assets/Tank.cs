using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    public float speed = 5;
    public float RotateSpeed = 90;
    public string Horiz;
    public string vertic;
    public KeyCode shootButton;
    public GameObject bullet;
    void Update()
    {

        var ver = Input.GetAxis(vertic);
        transform.position += transform.forward * speed * ver * Time.deltaTime;



        var hor = Input.GetAxis(Horiz);
        transform.Rotate(0, RotateSpeed * Time.deltaTime * hor, 0);

        if (Input.GetKeyDown(shootButton))
        {
            Instantiate(bullet,transform.position,transform.rotation);
        }
        
    }
}
