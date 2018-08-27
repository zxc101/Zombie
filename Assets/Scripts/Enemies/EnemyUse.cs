using UnityEngine;

public class EnemyUse : MonoBehaviour, IHealthPoints, IStrike, IView, IDeath
{
    [SerializeField] private int _hp;
    [SerializeField] private int _power;
    [SerializeField] private int _distance;

    private GameObject _enemy;

    private bool _isStrike;
    private bool _isDeath;

    public int HP
    {
        get { return _hp; }
        set { _hp = value; }
    }

    public bool IsStrike
    {
        get { return _isStrike; }
        set { _isStrike = value; }
    }

    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }

    public int Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public GameObject Enemy
    {
        get { return _enemy; }
        set { _enemy = value; }
    }

    public bool IsDeath
    {
        get { return _isDeath; }
        set { _isDeath = value; }
    }
}
