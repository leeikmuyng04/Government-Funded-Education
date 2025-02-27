using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    [SerializeField] Ray ray;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.Log("ray.origin : " + ray.origin);
            Debug.Log("ray.direction : " + ray.direction);
        }
    }
}
