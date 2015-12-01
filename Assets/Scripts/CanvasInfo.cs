using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasInfo : MonoBehaviour
{

    public Text Ammo;
    public Text XP;
    public Text Life;
    public Text GunName;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AmmoUpdate();
        XpUpdate();
        LifeUpdate();

    }


    void AmmoUpdate()
    {
        if (UserInfo.CurrentGun != null)
        {


            if (UserInfo.CurrentGun.bulletCount == 0)
            {
                Ammo.color = Color.red;
            }
            else
            {
                Ammo.color = Color.white;
            }
            Ammo.text = "Ammo: " + UserInfo.CurrentGun.bulletCount;
            GunName.text = "Gun: " + UserInfo.CurrentGun.GunName;
        }
    }
    void XpUpdate()
    {
        XP.text = "XP: " + UserInfo.XP;
    }

    void LifeUpdate()
    {
        if (UserInfo.Life == 0)
        {
            Life.color = Color.red;
        }
        else
        {
            Life.color = Color.white;
        }
        Life.text = "Life: " + UserInfo.Life;

    }
}
