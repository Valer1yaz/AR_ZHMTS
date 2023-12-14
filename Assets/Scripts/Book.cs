using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Book : MonoBehaviour
{
    [SerializeField] PlayerMoney _playerMoney;
    [SerializeField] public int _pointsForBird = 20;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "lb_bird")
        {
            _playerMoney.ProcessWin(_pointsForBird);
            _playerMoney.DeadBirdCount();
        }
    }
}
