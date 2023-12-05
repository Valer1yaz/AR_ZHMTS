using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using TMPro;
using System;

public class ARMenu : MonoBehaviour
{
    [SerializeField] private ItemsConfig _itemsConfig;
    [SerializeField] private GameObject _buttonPrefab;
    [SerializeField] private Transform _root;
    [SerializeField] private GridObjectCollection _gridObjectsCollection;
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] private TextMeshPro _titleMoney;
    [SerializeField] private TextMeshPro _titleBird;

    private void Start()
    {
        UpdateButtons();
    }

    public void UpdateButtons()
    {
        for (int i = 1; i < _root.childCount; i++) 
        {
            Destroy(_root.GetChild(i).gameObject);
        }

        foreach (var itemsConfigItem in _itemsConfig.Items)
        {
            if (!_playerMoney.CanBuy(itemsConfigItem.Price))
            {
                continue;
            }

            var button = Instantiate(_buttonPrefab, _root);

            if (button.TryGetComponent(out ARButton arButton))
            {
                arButton.Initialize(itemsConfigItem);
            }

            arButton.OnButtonClicked += () => ProcessBuy(itemsConfigItem.Price);
        }

        StartCoroutine(UpdateCollection());
    }

    private void ProcessBuy(int price)
    {
        _playerMoney.ProcessBuy(price);

        UpdateButtons();
    }

    private IEnumerator UpdateCollection()
    {
        yield return new WaitForEndOfFrame();
        _titleMoney.text = "Мана:" + Convert.ToString(_playerMoney.ReturnMoneyAmount());
        _titleBird.text = "Повержено:" + Convert.ToString(_playerMoney.ReturnBirdAmount());
        _gridObjectsCollection.UpdateCollection();
    }
}
