using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Camera camera;
    public GameObject cubePrefab;

    // Update is called once per frame
    void Update()
    {
      Touch touch;

      if (Input.touchCount > 0 && (touch = Input.GetTouch(0)).phase == TouchPhase.Began)
      {
        CreateCube(touch.position);
      }
      else if (Input.GetMouseButtonDown(0))
      {
        CreateCube(Input.mousePosition);
      }
    }

    void CreateCube(Vector2 position)
    {
      Ray ray = camera.ScreenPointToRay(position);
      Instantiate(cubePrefab, (ray.origin + ray.direction), Quaternion.identity);
    }
}
