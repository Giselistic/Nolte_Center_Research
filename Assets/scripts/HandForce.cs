using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandForce : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log (col);
        if (col.gameObject.TryGetComponent<BreakableWall>(out BreakableWall wall))
        {
            wall.ApplyForce(col.relativeVelocity.magnitude);
        }
    }
}

