using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject obj;
    public GameObject enemy;
    public GameObject _fx;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == enemy)
        {
            Instantiate(_fx, obj.transform.position, Quaternion.identity);
            Destroy(obj); // Уничтожаем объект, к которому прикреплен скрипт
            Destroy(_fx);
        }
    }
}
