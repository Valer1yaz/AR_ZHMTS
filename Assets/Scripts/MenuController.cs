using UnityEngine;

public class MenuController : MonoBehaviour
{
    // Вызывается при нажатии на кнопку "Пауза"
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
}
