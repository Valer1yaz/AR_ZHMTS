using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] PlayerMoney _playerMoney;
    [SerializeField] GameObject _fx;
    [SerializeField] GameObject _player;

    [SerializeField] float _spawnDistance = 1;

    [SerializeField] public int _price = 5;
    [SerializeField] public int _pointsForBird = 20;

    public lb_Bird _bird;


    private void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "lb_bird")
        {
            _playerMoney.ProcessWin(_pointsForBird);
            _playerMoney.DeadBirdCount();
        }
    }
    private void Start()
    {
        // ѕолучаем ссылку на игрока, если она не установлена
        if (_player == null)
        {
            _player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void MoveObject()
    {
        Vector3 playerPos = _player.transform.position;
        Vector3 playerDirection = _player.transform.forward;
        Quaternion playerRotation = _player.transform.rotation;

        Vector3 spawnPos = playerPos + playerDirection * _spawnDistance;

        if (_playerMoney.CanBuy(_price))
        {
            transform.position = spawnPos;
            _playerMoney.ProcessBuy(_price);
            Instantiate(_fx, spawnPos, playerRotation);
        }
    }
}
