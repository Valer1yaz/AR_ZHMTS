using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject player; // Ссылка на игрока
    [SerializeField] PlayerMoney _playerMoney;
    public int _price;

    private void Start()
    {
        // Получаем ссылку на игрока, если она не установлена
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void MoveObject()
    {
        if (_playerMoney.CanBuy(_price))
        {
            transform.position = player.transform.position;
            _playerMoney.ProcessBuy(_price);
        }
    }
}
