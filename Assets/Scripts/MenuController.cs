using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private PlayerMoney _playerMoney;
    [SerializeField] private TextMeshPro _titleBird;

    private void Update()
    {
        _titleBird.text = "Очки: " + Convert.ToString(_playerMoney.ReturnBirdAmount());
    }
    public void OnPauseButtonClicked()
    {
        // Ставим игру на паузу
        Time.timeScale = 0;
    }

    public void OnResumeButtonClicked()
    {
        // Снимаем с паузы
        Time.timeScale = 1;
    }

    // Вызывается при нажатии на кнопку "Выход"
    public void OnExitButtonClicked()
    {
        // Закрываем приложение
        Application.Quit();
    }

    public void OnRestartButtonClicked()
    {
        // Перезагружаем сцену заново
        SceneManager.LoadScene(0);
    }
}
