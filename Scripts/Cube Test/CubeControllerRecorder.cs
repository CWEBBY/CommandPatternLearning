using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPatternLearning.CubeTest
{
    public class CubeControllerRecorder : CommandRecorder<CubeMover, CubeController, CubeControllerRecord, CubeMovementData> { }
}
