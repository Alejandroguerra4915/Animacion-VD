using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void Update()
    {
     

        transform.position = target.position + offset;
    }


}
