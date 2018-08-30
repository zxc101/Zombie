using UnityEngine;

namespace IK.Humanoid.Hand.Middle
{
    [System.Serializable]
    public struct MiddleProximal
    {
        public Transform Transform;
        public MiddleIntermediate MiddleIntermediate;

        public MiddleProximal(Transform _Transform, MiddleIntermediate _MiddleIntermediate)
        {
            Transform = _Transform;
            MiddleIntermediate = _MiddleIntermediate;
        }
    }
}