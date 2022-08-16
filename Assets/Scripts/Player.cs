using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hackathon
{
    public class Player : MonoBehaviour
    {
        private ObstaclesChecker checker;

        // Start is called before the first frame update
        void Start()
        {
            checker = new ObstaclesChecker();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                float distance = 0;

                if (checker.Check(transform.position, transform.TransformDirection(Vector3.forward), out distance))
                {
                    Debug.Log("Hit distance " + distance);
                }
                else
                {
                    Debug.Log("Not hit");
                }
            }
        }
    }
} // namespace hackathon

