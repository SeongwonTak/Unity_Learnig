using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public int itemCount;
    public float jumpPower;
    bool isJump;
    Rigidbody rigid;
    AudioSource audio;

    private void Awake()
    {
        // Rigidbody 가져오기 및 각종 변수 초기화
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        isJump = false;
        itemCount = 0;
        
    }

    void FixedUpdate()
    {
        // 기본적인 이동 만들기
        // GetAxisRaw로 할 경우 음의 뱡향은 -1, 정지는 0, 양의 방향은 1
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
        
    }

    private void Update()
    {
        // 점프를 한번만 할 수 있게.
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 점프를 한번 뛰고 다시 바닥에 돌아오면 다시 점프하게 하려면 collision.
        if (collision.gameObject.tag == "Floor")
            isJump = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
        }
    }
}
