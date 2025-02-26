using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // Time.deltaTime
        // 마지막 프레임이 완료된 후 경과한 시간입니다.

        // 벡터의 정규화
        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
