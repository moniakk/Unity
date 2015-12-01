using UnityEngine;
using System.Collections;

public class Bullet1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, .1f, 0);
    }
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        BaseObject tmp = col.gameObject.GetComponent<BaseObject>();
        if (tmp != null)
        {
            UserInfo.Edit(tmp);
            Destroy(tmp.gameObject);

        }

    }
}
