using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _moneyAmount;
    [SerializeField] private int _deadbirdcount;

    public void ProcessBuy(int money)
    {
        if (_moneyAmount - money < 1)
        {
            return;
        }
        _moneyAmount -= money;
    }
    public bool CanBuy(int price)
    {
        return _moneyAmount - price >= 1;
        
    }
    public void DeadBirdCount()
    {
        _deadbirdcount ++;
    }

    public int ReturnMoneyAmount()
    {
        return _moneyAmount;
    }
    public int ReturnBirdAmount()
    {
        return _deadbirdcount;
    }
}
