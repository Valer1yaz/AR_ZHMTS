using UnityEngine;

public class MenuController : MonoBehaviour
{
    // ���������� ��� ������� �� ������ "�����"
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
}
