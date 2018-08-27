using UnityEngine;

public abstract class ViewAbstract : MonoBehaviour
{
    public float radius;
    [Range(0, 360)]
    public float angle;

    public Vector3 DirFromAngle(float angleInDistances, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDistances += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDistances * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDistances * Mathf.Deg2Rad));
    }
}
