using System;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.UI;



public class MagicButton : MonoBehaviour
{
    public event Action OnButtonClicked;

    [Header("Unity Setup")]

    [SerializeField] private TextMeshPro _title;
    [SerializeField] private Interactable _interactable;
    public GameObject _fx;



    private GameObject _prefab;

    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.Prefab;

        _interactable.OnClick.AddListener(ProcessClick);
    }

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        SpawnItem();
    }

    public void SpawnItem()
    {
        Instantiate(_fx, transform.position - new Vector3(0.3f, 0.3f), Quaternion.identity);
        Instantiate(_prefab, transform.position - new Vector3(0.3f, 0.3f), Quaternion.identity);
        Destroy(_fx);
    }

}