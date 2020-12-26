using System;
using UnityEngine;

[Serializable]
public abstract class Command<T, D> where T : CommandedObject<D>
{
    // MEMBERS
    [SerializeField] protected T _commandedObj;
    [SerializeField] protected D _data;

    // FUNCTIONS
    public void Execute() => _commandedObj.OnCommand(_data);
}