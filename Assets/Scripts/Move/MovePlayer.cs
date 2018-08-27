using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    [SerializeField] private float acceleration = 100;

    private Rigidbody rigidbody;
    private Vector3 lookPos;

    private void StartCoroutines()
    {
        StartCoroutine("LookWithDelay", GameSources.Instance.FrequencyOfActions/10);
        StartCoroutine("MoveWithDelay", GameSources.Instance.FrequencyOfActions);
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        StartCoroutines();
    }

    IEnumerator LookWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Look();
        }
    }

    IEnumerator MoveWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Move();
        }
    }

    private void Look()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            lookPos = hit.point;
        }

        Vector3 lookDir = lookPos - transform.position;
        lookDir.y = 0;

        transform.LookAt(transform.position + lookDir, Vector3.up);
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        rigidbody.velocity = movement * speed;
    }
}
