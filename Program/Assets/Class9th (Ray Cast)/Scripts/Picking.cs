using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picking : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] LayerMask layerMask;
    [SerializeField] RaycastHit rayCastHit;

    [SerializeField] float attack;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity, layerMask))
            {
                rayCastHit.collider.transform.root.GetComponent<Health>().OnDamage(attack);
            }
        }
    }
}
