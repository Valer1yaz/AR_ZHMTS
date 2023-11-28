using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    public GameObject _fx;
    public GameObject _fx2;
    private Animator m_animator;

    void Start()
    {

        m_animator = GetComponent<Animator>();

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "lb_perchTarget")
        {
            Debug.Log("dead");
            m_animator.SetTrigger("Dead");

            Instantiate(_fx, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject); // Уничтожаем объект, к которому прикреплен скрипт
            
        }
        else
        {
            Debug.Log("not dead");
            Instantiate(_fx2, this.transform.position, Quaternion.identity);
            m_animator.SetTrigger("Run");

            Destroy(this.gameObject, 5);
            
        }
    }
}
