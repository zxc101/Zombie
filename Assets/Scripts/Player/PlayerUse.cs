using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUse : MonoBehaviour, IHealthPoints
{
    [SerializeField] private int _hp;

    [SerializeField] private GameObject _weapon;

    [HideInInspector] public bool _isStrike;
    [HideInInspector] public bool _isDeath;

    public int HP
    {
        get { return _hp; }
        set { _hp = value; }
    }

    public GameObject Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    public bool IsDeath
    {
        get { return _isDeath; }
        set { _isDeath = value; }
    }
}
