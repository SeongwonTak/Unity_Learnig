using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{

    public float rotate_speed;

    // Update is called once per frame


    void Update()
    {
        // deltaTime�� ���� ȯ�濡 ���� ���̰� �߻����� �ʰ� �Ѵ�.
        // local ��ǥ�谡 �ƴ�, global�ϰ� �����Ѵ�.
        transform.Rotate(Vector3.up * rotate_speed * Time.deltaTime, Space.World);
        
    }


}
