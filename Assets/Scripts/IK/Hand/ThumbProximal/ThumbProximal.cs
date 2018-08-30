using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IK.Humanoid.Thumb
{
    [System.Serializable]
    public struct ThumbProximal
    {
        public Transform Transform;
        public ThumbIntermediate ThumbIntermediate;

        public ThumbProximal(Transform _Transform, ThumbIntermediate _ThumbIntermediate)
        {
            Transform = _Transform;
            ThumbIntermediate = _ThumbIntermediate;
        }
    }
}
