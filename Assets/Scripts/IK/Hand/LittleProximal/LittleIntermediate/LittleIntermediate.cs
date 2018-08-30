using UnityEngine;

namespace IK.Humanoid.Hand.Pinky
{
    [System.Serializable]
    public struct LittleIntermediate
    {
        public Transform Transform;
        public LittleDistal LittleDistal;

        public LittleIntermediate(Transform _Transform, LittleDistal _LittleDistal)
        {
            Transform = _Transform;
            LittleDistal = _LittleDistal;
        }
    }
}