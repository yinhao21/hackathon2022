using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace hackathon
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private InputActionReference singSongInputAction;
        [SerializeField] private GameObject audio_song;
        [SerializeField] private GameObject audio_foot;
        [SerializeField] private AudioSource echo_source;

        private ObstaclesChecker checker;
        private float distance;
        const float voice_speed = 100;      // 游戏里的音速（非物理）
        private AudioSource voice;
        private AudioSource footstep;
        private AudioEchoFilter voice_filter;
        private float obj_position_z;

        // Start is called before the first frame update
        void Start()
        {
            obj_position_z = this.transform.position.z;
            checker = new ObstaclesChecker();
            singSongInputAction.action.performed += Sing;
            distance = 0;
            
            voice = audio_song.GetComponent<AudioSource>();
            voice.Stop();
        }

        // Update is called once per frame
        void Update()
        {
            if (this.transform.position.z != obj_position_z)
            {
                audio_foot.GetComponent<AudioSource>().enabled = true;

                obj_position_z = this.transform.position.z;
            }
            else
            {
                audio_foot.GetComponent<AudioSource>().enabled = false;
            }
            
            if (checker.Check(transform.position, transform.TransformDirection(Vector3.forward), out distance))
            { 
                //Debug.Log("Hit distance " + distance);
            }else {
                //Debug.Log("Not hit");
            }
        }

        private void Sing(InputAction.CallbackContext obj)
        {
            PlayAudio(voice);
        }

        private void PlayAudio(AudioSource clip, UnityAction callback = null)
        {
            clip.Play();
            //执行协成获取音频文件的时间
            StartCoroutine(AudioPlayFinished(clip, distance / voice_speed, callback));
        }
        
        //执行协成函数 并且返回时间
        private IEnumerator AudioPlayFinished(AudioSource clip, float time, UnityAction callback)
        {   
            yield return new WaitForSeconds(time);
            echo_source.clip = clip.clip;
            echo_source.volume = Math.Max(10 / distance, 0); 
            echo_source.Play();
        }
    }
} // namespace hackathon

