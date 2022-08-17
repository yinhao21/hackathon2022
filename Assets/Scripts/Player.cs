using System;
using System.Collections;
using Unity.XR.PXR;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.XR;
using CommonUsages = UnityEngine.InputSystem.CommonUsages;

namespace hackathon
{
    public class Player : MonoBehaviour
    {
        public float speed;
        private ObstaclesChecker checker;
        //Unity New Input System input actions
        private ControllerSampleInputActions inputActions;

        // Start is called before the first frame update
        void Start()
        {
            checker = new ObstaclesChecker();
            inputActions = new ControllerSampleInputActions();
        }

        private void OnEnable()
        {
            inputActions.RightController.JoystickClick.Enable();
            
            inputActions.LeftController.JoystickClick.Enable();
        }

        private void OnDisable()
        {
            inputActions.RightController.JoystickClick.Disable();
            
            inputActions.LeftController.JoystickClick.Disable();
        }

        // Update is called once per frame
        void Update()
        {
            float angle = Input.GetAxis("HORIZONTAL");
            print(angle);
            //上    
            /*if (angle > 45 && angle < 135)
            {
    
                this.Translate(dic.forward  * Time.deltaTime * speed);
            }
            //下      
            else if (angle < -45 && angle > -135)
            {
    
                //Debug.Log("上");    
                this.Translate(-dic.forward * Time.deltaTime * speed);
            }
            //左      
            else if ((angle < 180 && angle > 135) || (angle < -135 && angle > -180))
            {
    
                //Debug.Log("左");    
                this.Translate(-dic.right * Time.deltaTime * speed);
            }
            //右      
            else if ((angle > 0 && angle < 45) || (angle > -45 && angle < 0))
            {
    
                //Debug.Log("右");    
                this.Translate(dic.right * Time.deltaTime * speed);
            }*/
            
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

