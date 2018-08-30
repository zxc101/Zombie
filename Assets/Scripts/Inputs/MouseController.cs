using System.Collections;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private WeaponController weaponController;
    private WeaponUse weapon;
    private Inventar inventar;
    private PlayerUse player;

    private void Start()
    {
        Init();
        HideAllWeapons();
        player.Weapon = inventar.Weapons[(int)EInventar.Weapon1];
        player.Weapon.SetActive(true);
    }

    private void Init()
    {
        inventar = FindObjectOfType<Inventar>();
        player = FindObjectOfType<PlayerUse>();
        if (player.Weapon.GetComponent<WeaponController>() != null)
        {
            weaponController = FindObjectOfType<PlayerUse>().Weapon.GetComponent<WeaponController>();
        }
        if (player.Weapon.GetComponent<WeaponUse>() != null)
        {
            weapon = FindObjectOfType<PlayerUse>().Weapon.GetComponent<WeaponUse>();
        }
    }

    private bool WeaponIsBlocked(int numberWeapon)
    {
        return inventar.Weapons[numberWeapon].GetComponent<WeaponUse>().IsBlocked;
    }

    private void ChoiseWeapon(int weaponsNumber)
    {
        if (!WeaponIsBlocked(weaponsNumber) && player.Weapon != inventar.Weapons[weaponsNumber])
        {
            player.Weapon.SetActive(false);
            player.Weapon = inventar.Weapons[weaponsNumber];
            player.Weapon.SetActive(true);
            weapon = player.Weapon.GetComponent<WeaponUse>();
            weaponController = player.Weapon.GetComponent<WeaponController>();
        }
    }

    private void HideAllWeapons()
    {
        foreach (GameObject weapon in inventar.Weapons)
        {
            weapon.SetActive(false);
        }
    }

    private void Update()
    {
        if(weapon.Type == EShootType.OneShoot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                weaponController.SetAudioClip(weapon.AudioClipShoot);
                weaponController.Shoot();
            }
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                weaponController.SetAudioClip(weapon.AudioClipShoot);
                weaponController.Shoot();
            }
        }

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
    }
}
