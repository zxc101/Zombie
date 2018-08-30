using UnityEngine;

namespace IK.Humanoid.Hand.Middle
{
    [System.Serializable]
    public struct MiddleDistal
    {
        public Transform Transform;

        public MiddleDistal(Transform _Transform)
        {
            Transform = _Transform;
        }
    }
}