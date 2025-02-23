using System;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    [SerializeField] Camera camera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            bool wasHit = Physics.Raycast(ray, out hitInfo);
            if (wasHit) 
            { 
               MeshRenderer meshRenderer = hitInfo.collider.gameObject.GetComponent<MeshRenderer>();
               if (meshRenderer != null)
               {
                   meshRenderer.material.color = Color.red;
               }
               else
               {
                   PlayerController playerController = hitInfo.collider.gameObject.GetComponent<PlayerController>();
                   if(playerController != null)
                       playerController.graphicsMeshRenderer.material.color = Color.red;
               }
            }
        }
    }
    
    
}
