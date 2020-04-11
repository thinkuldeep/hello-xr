using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private Vector3 rotation = new Vector3(20, 30, 0);
    void Update()
    {
      transform.Rotate(rotation * Time.deltaTime);
    }
}
