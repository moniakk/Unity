using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public static class UserInfo
{

    public static float SpeedMove = .1f;
    public static float Health = 100;
    public static float XP = 0f;
    public static int Life = 0;
    public static GunType CurrentGun;
    public static List<GunType> Guns = new List<GunType>();
    public static Text[] text;
    public static void Edit(BaseObject obj)
    {
        Health += obj.Health;
        SpeedMove += obj.SpeedMove;
        XP += obj.Xp;
        obj.Gun.AddGun();

        // Health += obj.Health;
        // Health += obj.Health;
    }
    public static void AddGun(this GunType gun)
    {
        if (!string.IsNullOrEmpty(gun.GunName))
        {
            if (!Guns.Exists(x => x.GunName == gun.GunName))
            {
                Guns.Add(gun);
            }
            else
            {
                Guns.First(x => x.GunName == gun.GunName).bulletCount += gun.bulletCount;
            }
            if (CurrentGun == null && Guns.Count > 0)
            {
                CurrentGun = Guns.First();
            }
        }
    }

    public static void NexGun()
    {
        CurrentGun = Guns[(Guns.IndexOf(CurrentGun) + 1) == Guns.Count ? 0 : (Guns.IndexOf(CurrentGun) + 1)];
    }
}

[System.Serializable]
public class GunType : System.Object
{
    public string GunName;
    public GameObject bullet;
    public int bulletCount = 10;
}
