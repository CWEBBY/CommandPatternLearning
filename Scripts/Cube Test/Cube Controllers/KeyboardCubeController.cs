using UnityEngine;

namespace CommandPatternLearning.CubeTest
{
    public class KeyboardCubeController : CubeController
    {
        // MEMBERS
        [Header("Controls")]
        [SerializeField] private KeyCode _forward = KeyCode.UpArrow;
        [SerializeField] private KeyCode _backward = KeyCode.DownArrow;
        [SerializeField] private KeyCode _left = KeyCode.LeftArrow;
        [SerializeField] private KeyCode _right = KeyCode.RightArrow;

        private CubeMovementData _movement;

        // CALLBACKS
        private void Update()
        {
            bool momentumChanged = ReadAxis(_forward, _backward, (int)_movement.Momentum, out int currentMomentumAxis);
            bool rotationChanged = ReadAxis(_right, _left, (int)_movement.Rotation, out int currentRotationAxis);
            _movement.Momentum = momentumChanged ? (CubeMovementData.MomentumDirection)currentMomentumAxis : _movement.Momentum;
            _movement.Rotation = rotationChanged ? (CubeMovementData.RotationDirection)currentRotationAxis : _movement.Rotation;
            if (momentumChanged || rotationChanged) Execute(Time.time, _movement);
        }

        // FUNCTIONS 
        private bool ReadAxis(KeyCode axisNeg, KeyCode axisPos, int previousReading, out int currentReading)
        {
            currentReading = 0;
            currentReading += Input.GetKey(axisNeg) ? 1 : 0;
            currentReading += Input.GetKey(axisPos) ? -1 : 0;
            return currentReading != previousReading;
        }
    }
}