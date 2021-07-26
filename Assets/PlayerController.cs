using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Camera myCam;

    [SerializeField]
    private NavMeshAgent player;
    
    // Update is called once per frame
    void Update()
    {
        //Movement
        if (Input.GetMouseButtonDown(0))
        {
            Ray mousePosRay =  myCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit mousePosHit;

            if (Physics.Raycast(mousePosRay, out mousePosHit))
            {
                player.SetDestination(mousePosHit.point);
            }
        }
    }
}
