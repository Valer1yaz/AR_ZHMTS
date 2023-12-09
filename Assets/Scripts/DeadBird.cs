using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBird : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] public int _points;


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "lb_bird")
        {
            _playerMoney.ProcessBuy(_points);
            _playerMoney.DeadBirdCount();
        }
    }

}
