using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float speed = 4;
    
    private Animator anim;
    private Vector3 lookPos;

    Transform cam;
    Vector3 camForward;
    Vector3 move;
    Vector3 moveInput;

    float forwardAmount;
    float turnAmount;

    void Start()
    {
        Init();
        StartCoroutines();
    }

    private void Init()
    {
        SetupAnimator();
        cam = Camera.main.transform;
    }

    private void StartCoroutines()
    {
        StartCoroutine("LookWithDelay", GameSources.Instance.RPS / 10);
        StartCoroutine("MoveWithDelay", GameSources.Instance.RPS);
    }

    private IEnumerator LookWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Look();
        }
    }

    private IEnumerator MoveWithDelay(float delay)
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

        if (cam != null)
        {
            camForward = Vector3.Scale(cam.up, new Vector3(1, 0, 1)).normalized;
        }

        move = vertical * camForward + horizontal * cam.right;

        if (move.magnitude > 1)
        {
            move.Normalize();
        }

        moveInput = move;

        ConvertMoveInput();
        UpdateAnimator();

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        GetComponent<Rigidbody>().velocity = movement * speed;
    }

    private void ConvertMoveInput()
    {
        Vector3 localMove = transform.InverseTransformDirection(moveInput);

        turnAmount = localMove.x;
        forwardAmount = localMove.z;
    }

    private void UpdateAnimator()
    {
        anim.SetFloat("Forward", forwardAmount);
        anim.SetFloat("Turn", turnAmount);
    }

    private void SetupAnimator()
    {
        anim = GetComponent<Animator>();

        foreach(var childAnimator in GetComponentsInChildren<Animator>())
        {
            if(childAnimator != anim)
            {
                anim.avatar = childAnimator.avatar;
                Destroy(childAnimator);
                break;
            }
        }
    }

    public bool IsGround()
    {
        Vector3 origin = transform.position;
        origin.y += 0.6f;
        Vector3 dir = -Vector3.up;
        float dis = 0.7f;
        RaycastHit hit;
        if (Physics.Raycast(origin, dir, out hit, dis))
        {
            Vector3 tp = hit.point;
            transform.position = tp;
            return true;
        }
        return false;
    }
}
