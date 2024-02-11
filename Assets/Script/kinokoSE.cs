using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kinokoSE : MonoBehaviour
{
    public AudioClip collisionSound; // �Փˎ��ɍĐ����鉹���t�@�C��
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂������肪Player�^�O�������Ă���ꍇ��SE���Đ�����
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }

}
