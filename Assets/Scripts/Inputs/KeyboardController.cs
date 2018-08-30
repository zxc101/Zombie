using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

    private Inventar inventar;
    private PlayerUse player;

    private void Start()
    {
        inventar = FindObjectOfType<Inventar>();
        player = FindObjectOfType<PlayerUse>();
        HideAllWeapons();
        player.Weapon = inventar.Weapons[(int)EInventar.Weapon1];
        player.Weapon.SetActive(true);
    }

    private bool WeaponIsBlocked(int numberWeapon)
    {
        return inventar.Weapons[numberWeapon].GetComponent<WeaponUse>().IsBlocked;
    }

    private void ChoiseWeapon(int weaponsNumber)
    {
        if(!WeaponIsBlocked(weaponsNumber) && player.Weapon != inventar.Weapons[weaponsNumber])
        {
            player.Weapon.SetActive(false);
            player.Weapon = inventar.Weapons[weaponsNumber];
            //player.Weapon.GetComponent<WeaponController>().SetAudioClip(player.Weapon.GetComponent<WeaponUse>().AudioShoot);
            player.Weapon.SetActive(true);
        }
    }

    private void HideAllWeapons()
    {
        foreach(GameObject weapon in inventar.Weapons)
        {
            weapon.SetActive(false);
        }
    }

    private void Update ()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ChoiseWeapon((int)EInventar.Weapon1);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChoiseWeapon((int)EInventar.Weapon2);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            ChoiseWeapon((int)EInventar.Weapon3);
        }

        //if (Input.GetKey(KeyCode.Alpha4))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon4);
        //}

        //if (Input.GetKey(KeyCode.Alpha5))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon5);
        //}

        //if (Input.GetKey(KeyCode.Alpha6))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon6);
        //}

        //if (Input.GetKey(KeyCode.Alpha7))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon7);
        //}

        //if (Input.GetKey(KeyCode.Alpha8))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon8);
        //}

        //if (Input.GetKey(KeyCode.Alpha9))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon9);
        //}

        //if (Input.GetKey(KeyCode.Alpha0))
        //{
        //    ChoiseWeapon((int)EInventar.Weapon10);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //}

        //if (Input.GetKey(KeyCode.C))
        //{
        //}

        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //}

        //if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.D))
        //{
        //}
    }
}
