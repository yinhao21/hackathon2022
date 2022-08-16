using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hackathon
{
    public class ObstaclesChecker
    {
        public bool Check(Vector3 origin, Vector3 forward)
        {
            RaycastHit sceneHit;

            if (Physics.Raycast(origin, forward, out sceneHit, Mathf.Infinity))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
} // namespace hackathon

