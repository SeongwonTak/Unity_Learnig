using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // player ��������
    Transform playerTransform;
    Vector3 Offset;
    
    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        // ī�޶� ���� �Ÿ�.
        Offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // UI upate�� Camera Update�� ���⼭ ó��
        // �� ������ �� �ϰ� �������� ó���ϴ� �ִ� LateUpdate
        transform.position = playerTransform.position + Offset;

        
    }
}
