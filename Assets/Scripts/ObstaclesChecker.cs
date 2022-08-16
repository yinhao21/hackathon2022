using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hackathon
{
    public class ObstaclesChecker
    {
        public bool Check(Vector3 origin, Vector3 forward, out float distance)
        {
            RaycastHit sceneHit;

            if (Physics.Raycast(origin, forward, out sceneHit, Mathf.Infinity))
            {
                distance = sceneHit.distance;

                return true;
            }
            else
            {
                distance = 0.0F;

                return false;
            }
        }
    }
} // namespace hackathon

