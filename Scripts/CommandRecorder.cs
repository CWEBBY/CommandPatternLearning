using UnityEngine;

public abstract class CommandRecorder<COM, CON, RECORD, DATA> : MonoBehaviour 
    where COM : CommandedObject<DATA> 
    where CON : CommandController<COM, DATA> 
    where RECORD : Record<DATA> // Very hacky way of getting Unity's serializer to show generics in the editor is to force the generic's type...
{
    protected enum RecordMode { Overwrite, Append }

    // MEMBERS
    [SerializeField] private CON _controller = null;
    [SerializeField] private RECORD _record = null;
    [SerializeField] private RecordMode _writeMode = RecordMode.Overwrite;

    // CALLBACKS
    private void Start() { if (_writeMode == RecordMode.Overwrite && _record) _record.Clear(); }
    private void OnEnable() => _controller.Executing += _record.Add;
    private void OnDisable() => _controller.Executing -= _record.Add;
}