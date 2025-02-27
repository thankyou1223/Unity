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
        // ���� ������Ʈ�� �������� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }

        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay
        // ���� ������Ʈ�� �������� �浹 ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }

        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollisionExit
        // ���� ������Ʈ�� �������� �浹�� ����� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.gameObject.name);
        }

        Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter
        // ���� ������Ʈ�� ���������� ���� �浹�� ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        // OnTriggerStay
        // ���� ������Ʈ�� ���������� ���� �浹 ���� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        // OnTriggerExit
        // ���� ������Ʈ�� ���������� ���� �浹�� ����� ��
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnTriggerExit");
    }
}
