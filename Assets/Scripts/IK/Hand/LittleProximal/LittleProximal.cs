using UnityEngine;

namespace IK.Humanoid.Hand.Pinky
{
    [System.Serializable]
    public struct LittleProximal
    {
        public Transform Transform;
        public LittleIntermediate LittleIntermediate;

        public LittleProximal(Transform _Transform, LittleIntermediate _LittleIntermediate)
        {
            Transform = _Transform;
            LittleIntermediate = _LittleIntermediate;
        }
    }
}