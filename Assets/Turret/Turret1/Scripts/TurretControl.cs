using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour
{

    public GameObject bullet;
    //public float Speed = .1f;
    public float ShootSpeed = .1f;
    Animator anim;
    float CloseTime = .1f;
    float lastShoot;
    void Start()
    {
        GunType gun = new GunType();
        gun.bullet = (GameObject)Resources.Load("Bullet/Prefab/bullet1");
        gun.GunName = "Gun1";
        gun.AddGun();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if ((Time.time - lastShoot) > 1)
        {
            anim.SetBool("Open", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            right();
        }
    }


    public void left()
    {
        transform.Translate(-UserInfo.SpeedMove, 0, 0);
        //  rigidBody2d.AddForce(new Vector2(-Speed * 100, 0));
    }
    public void right()
    {
        transform.Translate(UserInfo.SpeedMove, 0, 0);
        //   rigidBody2d.AddForce(new Vector2(Speed * 100, 0));
    }

    public void Shoot(bool UpperdownUser)
    {



        if (UserInfo.CurrentGun.bullet != null && UserInfo.CurrentGun.bulletCount > 0 && (UpperdownUser || (Time.time - lastShoot) > ShootSpeed))
        {
            anim.SetBool("Open", true);
            Instantiate(UserInfo.CurrentGun.bullet, transform.position, Quaternion.identity);
            lastShoot = Time.time;
            UserInfo.CurrentGun.bulletCount -= 1;
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        var tmp = col.gameObject.GetComponent<BaseObject>();
        if (tmp != null)
        {
            UserInfo.Edit(tmp);
            Destroy(tmp.gameObject);
        }
    }
}
