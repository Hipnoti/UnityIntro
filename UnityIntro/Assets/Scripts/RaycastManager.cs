using System;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    [SerializeField] Camera camera;

    private void Update()
    {
        Debug.Log("Last mouse scroll delta " + Input.mouseScrollDelta);
    }
}
