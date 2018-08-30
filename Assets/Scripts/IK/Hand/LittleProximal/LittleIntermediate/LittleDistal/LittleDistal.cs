using UnityEngine;

namespace IK.Humanoid.Hand.Pinky
{
    [System.Serializable]
    public struct LittleDistal
    {
        public Transform Transform;

        public LittleDistal(Transform _Transform)
        {
            Transform = _Transform;
        }
    }
}