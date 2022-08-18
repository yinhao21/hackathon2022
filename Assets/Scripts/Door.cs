using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hackathon
{
    public class Door : MonoBehaviour
    {
        private Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                bool isOpen = animator.GetBool("IsOpen");

                if (isOpen)
                {
                    animator.SetBool("IsOpen", false);
                }
                else
                {
                    animator.SetBool("IsOpen", true);
                }
            }
        }
    }
}
