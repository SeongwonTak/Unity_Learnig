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
        // Rigidbody �������� �� ���� ���� �ʱ�ȭ
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        isJump = false;
        itemCount = 0;
        
    }

    void FixedUpdate()
    {
        // �⺻���� �̵� �����
        // GetAxisRaw�� �� ��� ���� ������ -1, ������ 0, ���� ������ 1
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
        
    }

    private void Update()
    {
        // ������ �ѹ��� �� �� �ְ�.
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ������ �ѹ� �ٰ� �ٽ� �ٴڿ� ���ƿ��� �ٽ� �����ϰ� �Ϸ��� collision.
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
