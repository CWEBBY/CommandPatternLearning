using System.Collections.Generic;
using UnityEngine;

public abstract class Record<D> : ScriptableObject
{
    // MEMBERS
    // NOTE: Not meant to be played with in editor, I used a Dictionary only to find out that Unity doesn't seem to statically serialize them.
    // NOTE: None of this class is pretty, but laid out like I from the mindset of native C#, with property serialization and Dictionary support...
    [SerializeField] protected List<float> _timestamps = new List<float>();
    [SerializeField] protected List<D> _data = new List<D>();

    // PROPERTIES
    public int Count => _timestamps.Count;

    // FUNCTIONS
    public float GetKey(int index) => _timestamps[index];
    public D GetValue(int index) => _data[index];

    public void Add(float time, D data)
    {
        _timestamps.Add(time);
        _data.Add(data);
    }

    public void Clear()
    {
        _timestamps.Clear();
        _data.Clear();
    }
}
