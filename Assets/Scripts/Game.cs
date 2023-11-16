using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject obj;
    public GameObject _fx;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(obj.tag))
        {
            Instantiate(_fx, obj.transform.position, Quaternion.identity);
            Destroy(gameObject); // Уничтожаем объект, к которому прикреплен скрипт
            Destroy(_fx);
        }
    }
}
