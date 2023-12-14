using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    //����

    //HP
    public int heatl = 10;
    //����
    public int damage = 2;

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
        print("Heatl:" + heatl);
    }

    public void CollectCoins()
    {
        coins += 1;
        print("Coins" + coins);
    }
}
     