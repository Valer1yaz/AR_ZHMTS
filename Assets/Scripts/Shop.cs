using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] PlayerMoney _playerMoney;
    [SerializeField] GameObject _player;

    [SerializeField] float _spawnDistance = 1;
    [SerializeField] public int _price = 5;

    [SerializeField] public GameObject ShopPrefab;
    [SerializeField] GameObject _fx;

    // Start is called before the first frame update
    private void Start()
    {
        // ѕолучаем ссылку на игрока, если она не установлена
        if (_player == null)
        {
            _player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    public void SpawnBook()
    {
        Vector3 playerPos = _player.transform.position;
        Vector3 playerDirection = _player.transform.forward;
        Quaternion playerRotation = _player.transform.rotation;

        Vector3 spawnPos = playerPos + playerDirection * _spawnDistance;

        if (_playerMoney.CanBuy(_price))
        {
            _playerMoney.ProcessBuy(_price);
            Instantiate(ShopPrefab, spawnPos, playerRotation);
            Instantiate(_fx, spawnPos, playerRotation);
        }
    }

}
