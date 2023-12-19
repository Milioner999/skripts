using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{ 
    //����

    //HP
    public int heatl = 10;
    //����
    public int damage = 2;

    public AudioSource audioSource;

    public AudioClip damageSound;


    //���������� �����
    public int coins;
    //������
    public GameObject fireballPrefab;
    //��������� �.
    public Transform attackPoint;

    //����
    private void Update()
    {
        //���
        if (Input.GetMouseButtonDown(0))
        {
            //�����
            //�������
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //���������� HP
    public void TakeDamage(int damage)
    {
        heatl -= damage;
        if (heatl > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("�������� ������: " + heatl);

        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
    public void CollectCoins()
    {
        coins += 1;
        print("Coins" + coins);
    }
}
     