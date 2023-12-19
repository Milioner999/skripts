using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{ 
    //Поля

    //HP
    public int heatl = 10;
    //Урон
    public int damage = 2;

    public AudioSource audioSource;

    public AudioClip damageSound;


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
        if (heatl > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Здоровье игрока: " + heatl);

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
     