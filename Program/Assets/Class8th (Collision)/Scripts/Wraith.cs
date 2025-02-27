using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wraith : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.position = rigidBody.position + direction * speed * Time.deltaTime; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter 
        // 게임 오브젝트가 물리적인 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.

        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }

        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay
        // 게임 오브젝트가 물리적인 충돌 중일 때
        // 호출되는 이벤트 함수입니다.

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }

        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit
        // 게임 오브젝트가 물리적인 충돌을 벗어났을 때
        // 호출되는 이벤트 함수입니다.

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }

        Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter
        // 게임 오브젝트가 물리적이지 않은 충돌을 했을 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        // OnTriggerStay
        // 게임 오브젝트가 물리적이지 않은 충돌 중일 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        // OnTriggerExit
        // 게임 오브젝트가 물리적이지 않은 충돌을 벗어났을 때
        // 호출되는 이벤트 함수입니다.

        Debug.Log("OnTriggerExit");
    }
}
