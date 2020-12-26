using UnityEngine;

namespace CommandPatternLearning.SimonSays
{
    public class KeyboardSimonSequenceController : SimonSequenceController
    {
        [Header("Controls")]
        [SerializeField] private KeyCode _red = KeyCode.R;
        [SerializeField] private KeyCode _green = KeyCode.G;
        [SerializeField] private KeyCode _blue = KeyCode.B;
        [SerializeField] private KeyCode _yellow = KeyCode.Y;

        // CALLBACKS
        private void Update()
        {
            if (Input.GetKeyDown(_red)) Execute(Time.time, Color.red);
            if (Input.GetKeyDown(_green)) Execute(Time.time, Color.green);
            if (Input.GetKeyDown(_blue)) Execute(Time.time, Color.blue);
            if (Input.GetKeyDown(_yellow)) Execute(Time.time, Color.yellow);
        }
    }
}