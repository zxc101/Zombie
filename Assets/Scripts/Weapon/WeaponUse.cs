using IK.Humanoid.Hand;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUse : MonoBehaviour, IStrike
{
    [SerializeField] private EShootType _type;
    [SerializeField] private Transform _rightHand;
    [SerializeField] private Transform _leftHand;
    [SerializeField] private ParticleSystem _fireParticle;
    [SerializeField] private int _power;
    [SerializeField] private LineRenderer _tracer;
    [SerializeField] private float _frequencyDamage;
    [SerializeField] private bool _isBlocked;
    [SerializeField] private float _interval;
    [SerializeField] private AudioClip _audioClipShoot;
    [SerializeField] private float _shootDistance;

    private bool _isStrike;
    private Transform _target;

    public EShootType Type { get { return _type; } private set { } }
    public Transform RightHand { get { return _rightHand; } private set { } }
    public Transform LeftHand { get { return _leftHand; } private set { } }
    public ParticleSystem FireParticle { get { return _fireParticle; } private set {} }
    public int Power { get { return _power; } private set {} }
    public LineRenderer Tracer { get { return _tracer; } set { _tracer = value; } }
    public float FrequencyDamage { get { return _frequencyDamage; } set { _frequencyDamage = value; } }
    public float ShootDistance { get { return _shootDistance; } set { _shootDistance = value; } }
    public bool IsBlocked { get { return _isBlocked; } set { _isBlocked = value; } }
    public bool IsStrike { get { return _isStrike; } set { _isStrike = value; } }
    public Transform Target { get { return _target; } set { _target = value; } }
    public float Interval { get { return _interval; } set { _interval = value; } }
    public AudioClip AudioClipShoot { get { return _audioClipShoot; } private set { } }
}
