using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float surfaceOffset = 1.5f;

    private void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                transform.position = hit.point + hit.normal * surfaceOffset;
            }
        }
    }
}
