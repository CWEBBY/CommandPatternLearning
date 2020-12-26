using System;
using System.Collections;
using UnityEngine;

namespace CommandPatternLearning.SimonSays
{
    [Serializable]
    public class RecordSimonSequenceController : SimonSequenceController
    {
        // MEMBERS
        [SerializeField] private SimonSequenceRecord _record = null;

        // CALLBACKS
        private IEnumerator Start()
        {
            if (!_record) yield break;
            for (int i = 0; i < _record.Count; i++)
            {
                // This is not too fast, or memory saving, but a WaitForSeconds object can't reset the time, not really cachable.
                yield return new WaitForSeconds(_record.GetKey(i) - Time.time);
                Execute(Time.time, _record.GetValue(i));
            }
        }
    }
}