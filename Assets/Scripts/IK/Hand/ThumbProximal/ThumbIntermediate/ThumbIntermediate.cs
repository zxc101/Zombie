using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IK.Humanoid.Thumb
{
    [System.Serializable]
    public struct ThumbIntermediate
    {
        public Transform Transform;
        public ThumbDistal ThumbDistal;

        public ThumbIntermediate(Transform _Transform, ThumbDistal _ThumbDistal)
        {
            Transform = _Transform;
            ThumbDistal = _ThumbDistal;
        }
    }
}
