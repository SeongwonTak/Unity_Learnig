using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{

    public float rotate_speed;

    // Update is called once per frame


    void Update()
    {
        // deltaTime을 통해 환경에 따라서 차이가 발생하지 않게 한다.
        // local 좌표계가 아닌, global하게 적용한다.
        transform.Rotate(Vector3.up * rotate_speed * Time.deltaTime, Space.World);
        
    }


}
