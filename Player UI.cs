using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public TMPro.TextMeshProUGUI coins;
    public Slider health;
    public Player player;

    void Start()
    {
        coins.text = coins.text + player.coins;
        health.value = player.heatl;
        health.maxValue = player.maxHeatl;

    }
    private void Update()
    {
        health.value = player.heatl;
        coins.text = coins.text + player.coins;
    }
}