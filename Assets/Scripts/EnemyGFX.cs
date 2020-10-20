using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aIPath;

    void Update()
    {
        if(aIPath.desiredVelocity.x >= 0.01f)
        {
            //It controls the size of the bird
            transform.localScale = new Vector3(-10f, 10f, 1f);
        }
        else if(aIPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(10f, 10f, 1f);
        }
    }
}
