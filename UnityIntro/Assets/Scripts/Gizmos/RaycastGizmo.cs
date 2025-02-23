using System;
using UnityEngine;

public class RaycastGizmo : MonoBehaviour
{
    [SerializeField] Camera camera;
    
    private void OnDrawGizmos()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Gizmos.DrawRay(ray.origin, ray.direction);
    }
}
