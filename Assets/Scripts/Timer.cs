using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] private MenuController _menuController;
    public float _MainTimerEnd = 60;
    public bool GameOver;
    [SerializeField] public float _mainTimerValue = 0;

    private void Update()
    {
        if (!GameOver)
        {
            _mainTimerValue += Time.deltaTime;

            if (_mainTimerValue >= _MainTimerEnd)
            {
                _menuController.LOSER();
                GameOver = true;
            }
            else if (_playerMoney.ReturnBirdAmount() == 10 && _mainTimerValue < _MainTimerEnd)
            {
                _menuController.WINNER(Convert.ToInt32(_mainTimerValue));
                GameOver = true;
            }
        }
    }

    public void Reset()
    {
       _mainTimerValue = 0;
       GameOver = false;
    }
}
