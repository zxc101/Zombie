using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IK.Humanoid.Thumb
{
    [System.Serializable]
    public struct ThumbDistal
    {
        public Transform Transform;

        public ThumbDistal(Transform _Transform)
        {
            Transform = _Transform;
        }
    }
}
