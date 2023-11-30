using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    public GameObject _fx;
    public GameObject _fx2;
    private Animator anim;
    private int dieanim;
    private int runanim;
    private int idleanim;

    void Start()
    {
        anim = GetComponent<Animator>();
        dieanim = Animator.StringToHash("Dead");
        runanim = Animator.StringToHash("Run");
        idleanim = Animator.StringToHash("Idle");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Book")
        {
            anim.SetTrigger(dieanim);

            Instantiate(_fx, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject); // Уничтожаем объект, к которому прикреплен скрипт
            
        }
        else
        {
            Instantiate(_fx2, this.transform.position, Quaternion.identity);
            anim.SetTrigger(runanim);
        }
    }
}
