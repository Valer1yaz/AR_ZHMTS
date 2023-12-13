using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _pointsAmount;
    [SerializeField] private int _deadbirdcount;

    // Зарабатывание и трата очков (маны)

    public void ProcessWin(int points)
    {
        _pointsAmount += points;
    }

    public void ProcessBuy(int points)
    {
        _pointsAmount -= points;
    }

    public bool CanBuy(int points)
    {
        if (_pointsAmount - points >= 0)
        {
            return true;
        }
        else { return false; }
    }

    public int ReturnPointsAmount()
    {
        return _pointsAmount;
    }

    // Подсчёт убитых птиц

    public void DeadBirdCount()
    {
        _deadbirdcount ++;
    }


    public int ReturnBirdAmount()
    {
        return _deadbirdcount;
    }
}
