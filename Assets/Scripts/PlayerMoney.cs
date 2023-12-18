using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _deadbirdcount;

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
