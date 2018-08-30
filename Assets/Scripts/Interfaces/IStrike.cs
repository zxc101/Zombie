using UnityEngine;

public interface IStrike
{
    bool IsStrike { get; set; }
    int Power { get; }
    Transform Target { get; set; }
}
