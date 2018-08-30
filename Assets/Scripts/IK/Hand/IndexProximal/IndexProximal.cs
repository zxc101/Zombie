using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IK.Humanoid.Hand.Index
{
    [System.Serializable]
    public struct IndexProximal
    {
        public Transform Transform;
        public IndexIntermediate IndexIntermediate;

        public IndexProximal(Transform _Transform, IndexIntermediate _IndexIntermediate)
        {
            Transform = _Transform;
            IndexIntermediate = _IndexIntermediate;
        }
    }
}