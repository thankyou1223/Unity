using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State: MonoBehaviour
{
    private void Awake()
    {
        // Awake 함수란?
        // 게임 오브젝트 생성되었을 때, 
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start 함수한?
        // 게임 오브젝트가 활성화되었을 때 호출되며, 단 한번만 호출되는
        // 컴포너트가 비활성화 되었을 때 호출되지 않는 이벤트 함수입니다

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate 함수란?
        // 게임 오브젝트가 활성화되었을 떄 호출되며, Time Step에 설정된 값에 따라
        // 일정한 주기로 호출되는 이벤트 함수입니다.

        Debug.Log("FixedUpdate");

    }

    void Update()
    {
        // Update 함수란?
        // 게임 오브젝트가 활성화되었을 때 호출되며, 프레임 간격으로 호출되는
        // 이벤트 함수입니다.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate 함수한?
        // 게임 오브젝트가 활성화되었을 떄 호출되며, Update가 끝난 뒤에
        // 호출되는 이벤트 함수입니다.

        Debug.Log("Late Update");

    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //OnDestroy 함수란?
        // 게임 오브젝트
        Debug.Log("OnDestroy");
    }
}
