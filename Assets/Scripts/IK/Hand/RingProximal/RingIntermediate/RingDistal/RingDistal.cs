using UnityEngine;

namespace IK.Humanoid.Hand.Ring
{
    [System.Serializable]
    public struct RingDistal
    {
        public Transform Transform;

        public RingDistal(Transform _Transform)
        {
            Transform = _Transform;
        }
    }
}