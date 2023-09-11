using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float speed = 100f;
 
    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime));
    }
}
