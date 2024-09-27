using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour
{
    float xAxis;
    float zAxis;


    // Start is called before the first frame update
    void Start()
    {

    }


    private void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Debug.Log(xAxis + ", " + zAxis);
        transform.Rotate(xAxis, 0, zAxis);
    }

}
