using UnityEngine;

namespace IK.Humanoid.Hand.Middle
{
    [System.Serializable]
    public struct MiddleIntermediate
    {
        public Transform Transform;
        public MiddleDistal MiddleDistal;

        public MiddleIntermediate(Transform _Transform, MiddleDistal _MiddleDistal)
        {
            Transform = _Transform;
            MiddleDistal = _MiddleDistal;
        }
    }
}