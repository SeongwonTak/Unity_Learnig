using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // player 가져오기
    Transform playerTransform;
    Vector3 Offset;
    
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        // 카메라 보정 거리.
        Offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // UI upate나 Camera Update는 여기서 처리
        // 할 연산을 다 하고 마지막에 처리하는 애는 LateUpdate
        transform.position = playerTransform.position + Offset;

        
    }
}
