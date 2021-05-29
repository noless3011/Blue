using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey){
            cube.transform.Translate(Vector3.up*Time.deltaTime, Space.World);
        }
    }
}
