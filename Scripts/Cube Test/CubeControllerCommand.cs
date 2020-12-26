using System;

namespace CommandPatternLearning.CubeTest
{
    [Serializable]
    public class CubeControllerCommand : Command<CubeMover, CubeMovementData>
    {
        public CubeControllerCommand(CubeMover mover, CubeMovementData data)
        {
            _commandedObj = mover;
            _data = data;
        }
    }
}
