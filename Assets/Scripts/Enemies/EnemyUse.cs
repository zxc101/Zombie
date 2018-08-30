using UnityEngine;

public class EnemyUse : MonoBehaviour, IHealthPoints, IStrike, IView
{
    [SerializeField] private int _hp;
    [SerializeField] private int _power;
    [SerializeField] private float _distance;

    private Transform _target;

    private bool _isStrike;
    private bool _isDeath;

    public int HP { get { return _hp; } set { _hp = value; } }
    public bool IsStrike { get { return _isStrike; } set { _isStrike = value; } }
    public int Power { get { return _power; } set { _power = value; } }
    public float Distance { get { return _distance; } set { _distance = value; } }
    public Transform Target { get { return _target; } set { _target = value; } }
    public bool IsDeath { get { return _isDeath; } set { _isDeath = value; } }
}
