using UnityEngine;

namespace CommandPatternLearning.CubeTest
{
    [RequireComponent(typeof(Rigidbody))]
    public class CubeMover : CommandedObject<CubeMovementData>
    {
        // MEMBERS
        [SerializeField] private float _speed = 1f;
        [SerializeField] private float _sensitivity = 1f;

        private Rigidbody _rbody;

        // CALLBACKS
        private void Awake() => _rbody = GetComponent<Rigidbody>();

        private void Update()
        {
            _rbody.velocity = _rbody.velocity = transform.forward * (float)_data.Momentum * _speed;
            _rbody.angularVelocity = Vector3.up * (float)_data.Rotation * _sensitivity;
        }
    }
}