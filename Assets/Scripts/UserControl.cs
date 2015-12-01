using UnityEngine;
using System.Collections;

public class UserControl : MonoBehaviour
{
    TurretControl control;
    GameObject controlObject;
    ArrowDownNow keybord;
    bool ShootStart;
    void Start()
    {
        controlObject = GameObject.Find("Turret");
        if (controlObject != null)
        {
            control = controlObject.GetComponent<TurretControl>();
        }
    }

    void Update()
    {
        if (ShootStart)
        {
            control.Shoot(false);
        }

        switch (keybord)
        {
            case ArrowDownNow.left:
                control.left();
                break;
            case ArrowDownNow.right:
                control.right();
                break;


        }

    }

    public void Left()
    {
        keybord = ArrowDownNow.left;
    }

    public void Right()
    {
        keybord = ArrowDownNow.right;
    }

    public void Shoot()
    {
        control.Shoot(true);
        ShootStart = true;

    }


    public void UnpressedArrow()
    {

        keybord = ArrowDownNow.passed;
    }

    public void UnpressedArrowShoot()
    {

        ShootStart = false;
    }

    public void NextGun()
    {
        UserInfo.NexGun();
    }

    public enum ArrowDownNow
    {
        passed = 0,
        left = 1,
        right = 2
    }
}
