using UnityEngine;

namespace IK.Humanoid.Hand.Ring
{
    [System.Serializable]
    public struct RingIntermediate
    {
        public Transform Transform;
        public RingDistal RingDistal;

        public RingIntermediate(Transform _Transform, RingDistal _RingDistal)
        {
            Transform = _Transform;
            RingDistal = _RingDistal;
        }
    }

}