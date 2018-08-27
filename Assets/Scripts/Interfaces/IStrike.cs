using UnityEngine;

public interface IStrike
{
    bool IsStrike { get; set; }
    int Power { get; set; }
    GameObject Enemy { get; set; }
}
