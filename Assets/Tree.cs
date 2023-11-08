using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public GameObject tree;
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "tree")
        {
            tree.GetComponent<MeshRenderer>().enabled = false;
            cube.GetComponent<MeshRenderer>().enabled = true;
            cube1.GetComponent<MeshRenderer>().enabled = true;
            cube2.GetComponent<MeshRenderer>().enabled = true;
            cube3.GetComponent<MeshRenderer>().enabled = true;
            cube4.GetComponent<MeshRenderer>().enabled = true;
            cube5.GetComponent<MeshRenderer>().enabled = true;
            cube6.GetComponent<MeshRenderer>().enabled = true;

        }
    }
}
