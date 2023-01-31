using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour
{

    NavMeshAgent playerAgent;

    private void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();
    }

    //Gets the raycast from mouse and camera to interact with object
    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit ineractionInfo;
        if(Physics.Raycast(interactionRay, out ineractionInfo, Mathf.Infinity))
        {
            GameObject interactedObject = ineractionInfo.collider.gameObject;

            if( interactedObject.tag == "Interactable Object")
            {
                interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
            }
            else
            {
                playerAgent.stoppingDistance = 0;
                playerAgent.destination = ineractionInfo.point;
            }
        }
    }



}
