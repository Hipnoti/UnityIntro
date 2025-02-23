using System;
using UnityEngine;

public class LevelEndObjectGizmo : MonoBehaviour
{
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
