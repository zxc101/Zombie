using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IK.Humanoid.Hand.Index
{
    [System.Serializable]
    public struct IndexIntermediate
    {
        public Transform Transform;
        public IndexDistal IndexDistal;

        public IndexIntermediate(Transform _Transform, IndexDistal _IndexDistal)
        {
            Transform = _Transform;
            IndexDistal = _IndexDistal;
        }
    }
}