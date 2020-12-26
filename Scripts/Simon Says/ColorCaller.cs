using UnityEngine;

namespace CommandPatternLearning.SimonSays
{
    public class ColorCaller : CommandedObject<Color>
    {
        // FUNCTIONS
        public override void OnCommand(Color commandData)
            => Debug.Log($"{{R: {commandData.r}, G: {commandData.g}, B: {commandData.b}}} @ {Time.time}");
    }
}