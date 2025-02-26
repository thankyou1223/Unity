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
        // ������ �������� �Ϸ�� �� ����� �ð��Դϴ�.

        // ������ ����ȭ
        direction.Normalize();

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
