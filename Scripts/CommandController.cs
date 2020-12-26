using System;
using UnityEngine;

public abstract class CommandController<COM, DATA> : MonoBehaviour where COM : CommandedObject<DATA>
{
    // MEMBERS
    [SerializeField] protected COM _commandedObj = null;

    // PROPERTIES
    public event Action<float, DATA> Executing;

    // FUNCTIONS
    protected void Execute(float timeExecuted, DATA data)
    {
        _commandedObj.OnCommand(data);
        Executing?.Invoke(timeExecuted, data);
    }
}