using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IK.Humanoid.Hand.Index
{
    [System.Serializable]
    public struct IndexDistal
    {
        public Transform Transform;

        public IndexDistal(Transform _Transform)
        {
            Transform = _Transform;
        }
    }
}