using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    [SerializeField] private int _deadbirdcount;

    // ������� ������ ����
    public void DeadBirdCount()
    {
        _deadbirdcount ++;
    }

    public int ReturnBirdAmount()
    {
        return _deadbirdcount;
    }
}
