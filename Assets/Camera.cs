using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = (target1.position + target2.position) / 2;
        transform.position = Vector3.Lerp(transform.position, pos, 0.1f);
    }
}
