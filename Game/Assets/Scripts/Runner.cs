using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoadLine
{
    LEFT = -1,
    MIDDLE = 0,
    RIGHT = 1,
}

public class Runner : MonoBehaviour
{
    [SerializeField] RoadLine roadLine;

    [SerializeField] int positionX = 4;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] float speed = 20f;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }


    private void OnEnable()
    {
        InputManager.Instance.action += OnKeyUpdate;
    }

    private void FixedUpdate()
    {
        if (GameManager.Instance)
        {

        }

        Move();
    }

    void OnKeyUpdate()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(roadLine != RoadLine.LEFT)
            {
                animator.Play("Left Avoid");

                roadLine--;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (roadLine != RoadLine.RIGHT)
            {
                animator.Play("Right Avoid");

                roadLine++;
            }
        }
    }

    void Move()
    {
        rigidBody.position = Vector3.Lerp(rigidBody.position, new Vector3((int)roadLine * positionX, 0, 0), Time.deltaTime * speed);


    }

    private void OnDisable()
    {
        InputManager.Instance.action -= OnKeyUpdate;
    }

    
}
