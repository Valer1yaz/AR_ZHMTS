using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEditor.XR.ARSubsystems;

public class ARMenu : MonoBehaviour
{
    [SerializeField] private ItemsConfig _itemsConfig;
    [SerializeField] private GameObject _buttonPrefab;
    [SerializeField] private Transform _root;
    [SerializeField] private GridObjectCollection _gridObjectsCollection;

    private void Start()
    {
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        foreach (var itemsConfigItem in _itemsConfig.Items)
        {
            var button = Instantiate(_buttonPrefab, _root);

            if (button.TryGetComponent(out ARButton arButton))
            {
                arButton.Initialize(itemsConfigItem);
            }
        }
    }
}
