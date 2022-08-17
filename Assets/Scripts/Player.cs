using System;
using System.Collections;
using UnityEditor.UIElements;
using UnityEngine;

namespace hackathon
{
    public class Player : MonoBehaviour
    {
        private ObstaclesChecker checker;
        float distance;

        // Start is called before the first frame update
        void Start()
        {
            checker = new ObstaclesChecker();
            distance = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (checker.Check(transform.position, transform.TransformDirection(Vector3.forward), out distance))
            { 
                Debug.Log("Hit distance " + distance);
            }else {
                Debug.Log("Not hit");
            }
        }
    }
} // namespace hackathon

