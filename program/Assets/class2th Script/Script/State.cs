using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State: MonoBehaviour
{
    private void Awake()
    {
        // Awake �Լ���?
        // ���� ������Ʈ �����Ǿ��� ��, 
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǹ�, �� �ѹ��� ȣ��Ǵ�
        // ������Ʈ�� ��Ȱ��ȭ �Ǿ��� �� ȣ����� �ʴ� �̺�Ʈ �Լ��Դϴ�

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǹ�, Time Step�� ������ ���� ����
        // ������ �ֱ�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("FixedUpdate");

    }

    void Update()
    {
        // Update �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǹ�, ������ �������� ȣ��Ǵ�
        // �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate �Լ���?
        // ���� ������Ʈ�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǹ�, Update�� ���� �ڿ�
        // ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Late Update");

    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //OnDestroy �Լ���?
        // ���� ������Ʈ
        Debug.Log("OnDestroy");
    }
}
