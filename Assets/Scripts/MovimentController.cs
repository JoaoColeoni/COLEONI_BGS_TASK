using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool inAction;
    public Transform movePoint;
    public LayerMask whatStopMovement;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;   
    }

    // Update is called once per frame
    void Update()
    {
        if(inAction)
            return;

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= .005f)
        {
            animator.SetFloat("Speed", 0);
            if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopMovement) && Mathf.Abs(Input.GetAxis("Horizontal")) > 0.25f)
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
                    animator.SetFloat("Vertical", 0);
                    animator.SetFloat("Speed", moveSpeed);
                }
            }
            else if(Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopMovement) && Mathf.Abs(Input.GetAxis("Vertical")) > 0.25f)
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    animator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
                    animator.SetFloat("Horizontal", 0);
                    animator.SetFloat("Speed", moveSpeed);
                }
            }
        }
    }
}
