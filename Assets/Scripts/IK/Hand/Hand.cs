using IK.Humanoid.Hand.Index;
using IK.Humanoid.Hand.Middle;
using IK.Humanoid.Hand.Pinky;
using IK.Humanoid.Hand.Ring;
using IK.Humanoid.Thumb;
using UnityEngine;


namespace IK.Humanoid.Hand
{
    [System.Serializable]
    public struct Hand
    {
        public Transform Transform;

        public LittleProximal LittleProximal;
        public RingProximal RingProximal;
        public MiddleProximal MiddleProximal;
        public IndexProximal IndexProximal;
        public ThumbProximal ThumbProximal;

        public Hand(Transform _Transform, LittleProximal _LittleProximal, RingProximal _RingProximal, MiddleProximal _MiddleProximal, IndexProximal _IndexProximal, ThumbProximal _ThumbProximal)
        {
            Transform = _Transform;
            LittleProximal = _LittleProximal;
            RingProximal = _RingProximal;
            MiddleProximal = _MiddleProximal;
            IndexProximal = _IndexProximal;
            ThumbProximal = _ThumbProximal;
        }
    }
}