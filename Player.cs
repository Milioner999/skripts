using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    //Поля

    //HP
    public int heatl = 10;
    //Урон
    public int damage = 2;

    //Количество монет
    public int coins;
    //Снаряд
    public GameObject fireballPrefab;
    //Появление с.
    public Transform attackPoint;

    //Кадр
    private void Update()
    {
        //ЛКМ
        if (Input.GetMouseButtonDown(0))
        {
            //Копия
            //Поворот
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    //Уменьшение HP
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
     