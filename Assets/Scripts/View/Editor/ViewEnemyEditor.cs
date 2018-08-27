using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ViewEnemy))]
public class ViewEnemyEditor : Editor
{
    private void OnSceneGUI()
    {
        ViewEnemy viewPlayer = (ViewEnemy)target;

        Handles.color = Color.white;
        Handles.DrawWireArc(viewPlayer.transform.position, Vector3.up, Vector3.forward, 360, viewPlayer.radius);

        Vector3 viewAngleA = viewPlayer.DirFromAngle(-viewPlayer.angle / 2, false);
        Vector3 viewAngleB = viewPlayer.DirFromAngle(viewPlayer.angle / 2, false);

        Handles.DrawLine(viewPlayer.transform.position, viewPlayer.transform.position + viewAngleA * viewPlayer.radius);
        Handles.DrawLine(viewPlayer.transform.position, viewPlayer.transform.position + viewAngleB * viewPlayer.radius);

        Handles.color = Color.red;
        if (viewPlayer.Enemy)
        {
            Handles.DrawLine(viewPlayer.transform.position, viewPlayer.Enemy.transform.position);
        }
    }
}
