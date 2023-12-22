using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] private TextMeshPro _titleBird;
    [SerializeField] private TextMeshPro _time;

    [SerializeField] private Timer _timer;
    [SerializeField] private lb_BirdController _birdController;

    [SerializeField] private TextMeshPro _gameovertext;
    [SerializeField] private GameObject _storeMenu;
    [SerializeField] private GameObject _gameOverMenu;

    private void Start()
    {
        _timer.GameOver = false;
    }

    private void Update()
    {
        _titleBird.text = "Очки: " + Convert.ToString(_playerMoney.ReturnBirdAmount());
        _time.text = "Таймер: " + Convert.ToString(Convert.ToInt32(_timer._MainTimerEnd- _timer._mainTimerValue));
    }

    public void LOSER()
    {
        _storeMenu.SetActive(false);
        _gameOverMenu.SetActive(true);
        _gameovertext.text = "Проигрыш! Счёт: " + Convert.ToString(_playerMoney.ReturnBirdAmount());
        _birdController.AllPause();
    }

    public void WINNER(int totaltime)
    {
        _storeMenu.SetActive(false);
        _gameOverMenu.SetActive(true);
        _gameovertext.text = "Победа! Ты упел за " + Convert.ToString(totaltime) + " секунд!";
        _birdController.AllPause();
    }

    // Вызывается при нажатии на кнопку "Выход"
    public void OnExitButtonClicked()
    {
        // Закрываем приложение
        Application.Quit();
    }

    public void OnRestartButtonClicked()
    {
        _storeMenu.SetActive(true);
        _gameOverMenu.SetActive(false);
        _timer.Reset();

        // Перезагружаем сцену заново
        SceneManager.LoadScene(0);
    }
}
