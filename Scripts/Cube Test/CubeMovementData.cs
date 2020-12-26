using System;
using UnityEngine;

namespace CommandPatternLearning.CubeTest
{
    [Serializable]
    public struct CubeMovementData
    {
        public enum MomentumDirection { Backward = -1, None = 0, Forward = 1 }
        public enum RotationDirection { Left = -1, None = 0, Right = 1 }

        // CONSTRUCTORS
        public CubeMovementData(MomentumDirection momentum, RotationDirection rotation)
        {
            _momentum = momentum;
            _rotation = rotation;
        }

        // MEMBERS
        [SerializeField] private MomentumDirection _momentum;
        [SerializeField] private RotationDirection _rotation;

        // PROPERTIES
        public MomentumDirection Momentum { get => _momentum; set => _momentum = value; }
        public RotationDirection Rotation { get => _rotation; set => _rotation = value; }
    }
}