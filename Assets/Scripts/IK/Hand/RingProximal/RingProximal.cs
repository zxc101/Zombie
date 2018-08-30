using UnityEngine;

namespace IK.Humanoid.Hand.Ring
{
    [System.Serializable]
    public struct RingProximal
    {
        public Transform Transform;
        public RingIntermediate RingIntermediate;

        public RingProximal(Transform _Transform, RingIntermediate _RingIntermediate)
        {
            Transform = _Transform;
            RingIntermediate = _RingIntermediate;
        }
    }
}