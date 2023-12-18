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
        _titleBird.text = "����: " + Convert.ToString(_playerMoney.ReturnBirdAmount());
    }
    public void OnPauseButtonClicked()
    {
        // ������ ���� �� �����
        Time.timeScale = 0;
    }

    public void OnResumeButtonClicked()
    {
        // ������� � �����
        Time.timeScale = 1;
    }

    // ���������� ��� ������� �� ������ "�����"
    public void OnExitButtonClicked()
    {
        // ��������� ����������
        Application.Quit();
    }

    public void OnRestartButtonClicked()
    {
        // ������������� ����� ������
        SceneManager.LoadScene(0);
    }
}
