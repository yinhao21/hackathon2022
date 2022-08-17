using System;
using System.Collections;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.InputSystem;

namespace hackathon
{
    public class Player : MonoBehaviour
    {
        public AudioSource voice;
        public AudioSource footstep;
        [SerializeField] private InputActionReference singSongInputAction;
        private ObstaclesChecker checker;
        float distance;
        const float voice_speed = 100;      // 游戏里的音速（非物理）
        

        // Start is called before the first frame update
        void Start()
        {
            checker = new ObstaclesChecker();
            singSongInputAction.action.performed += Sing;
            distance = 0;
            voice.Stop();
            footstep.Stop();
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

        private void Sing(InputAction.CallbackContext obj)
        {
            voice.Play();
        }
    }
} // namespace hackathon

