using UnityEngine;

public abstract class CommandedObject<D> : MonoBehaviour
{
    protected D _data;
    public virtual void OnCommand(D commandData) => _data = commandData;
}