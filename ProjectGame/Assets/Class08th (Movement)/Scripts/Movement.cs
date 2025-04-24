using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] Vector3 direction;

    void Update()
    {
        //direction.x = Input.GetAxis("Horizontal"); // 이것은 줄어드는 형식이라 잔여값으로 인해 조금 더 움직임
        direction.x = Input.GetAxisRaw("Horizontal");
        //direction.y = Input.GetAxis("Depth");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        transform.position += direction * Time.deltaTime * speed;

        Debug.Log(direction);   // (0.00, 0.00, 0.00)

        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;

            //transform.position += new Vector3(0, 0, 1);
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        */
    }
}
