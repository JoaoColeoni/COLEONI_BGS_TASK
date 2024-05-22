using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask whatStopMovement;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= .005f)
        {
            if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, whatStopMovement) && Mathf.Abs(Input.GetAxis("Horizontal")) > 0.25f)
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
            else if(Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, whatStopMovement) && Mathf.Abs(Input.GetAxis("Vertical")) > 0.25f)
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }
}
