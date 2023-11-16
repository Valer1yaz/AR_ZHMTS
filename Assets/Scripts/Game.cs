using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject obj;
    public GameObject _fx;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "scissors" && obj.tag == "tape")
        {
            Instantiate(_fx, obj.transform.position, Quaternion.identity);
            Destroy(this.gameObject); // ���������� ������, � �������� ���������� ������
        }
        else if (collider.gameObject.tag == "tape" && obj.tag == "stapler")
        {
            Instantiate(_fx, obj.transform.position, Quaternion.identity);
            Destroy(this.gameObject); // ���������� ������, � �������� ���������� ������
        }
        else if (collider.gameObject.tag == "stapler" && obj.tag == "scissors")
        {
            Instantiate(_fx, obj.transform.position, Quaternion.identity);
            Destroy(this.gameObject); // ���������� ������, � �������� ���������� ������
        }
        else
        {
            Instantiate(_fx, obj.transform.position, Quaternion.identity);
        }
    }
}
