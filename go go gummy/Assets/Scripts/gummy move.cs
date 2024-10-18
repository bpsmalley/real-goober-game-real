using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class somethign : MonoBehaviour
{
    public NavMeshAgent myAgent;
    public float moveSpeed = 100;
    public Transform gummyVisTransform;
    public LayerMask whatIsGround;
    public LayerMask interactable;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(myRay, out hit, 100, interactable))
            {
                myAgent.SetDestination(hit.collider.transform.GetChild(0).transform.position);
            }

            else if (Physics.Raycast(myRay, out hit, 100, whatIsGround))
            {
                myAgent.SetDestination(hit.point);
            }

        }
    }
}
