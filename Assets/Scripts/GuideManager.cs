using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace hackathon
{
    public class GuideManager : MonoBehaviour
    {
        [SerializeField] private InputActionReference singSongInputAction;
        public GameObject lomoSys;
        bool tapA = false;
        class Dialog
        {
            public enum Type
            {
                COMMON,
                ACTION
            }
        

            public Dialog(string audio, Type eventType, Func<bool> action = null)
            {
                this.audio = audio;
                this.eventType = eventType;
                this.isRunning = false;
                this.clip = null;
                this.OnAction = action;
            }

            public string audio;

            public Type eventType;

            public bool isRunning;
            
            public AudioClip clip;

            public Func<bool> OnAction;

        }

        #region Audios
        private static readonly string AUDIOS_PATH = "Audio" + Path.DirectorySeparatorChar + "Dialogs";

        private List<Dialog> dialogs;

        private AudioSource audioSource;

        private int dialogCuror = 0;

        #endregion

        bool SingSong()
        {
            if (audioSource.clip.name == "啊1") { return true; }
            return false;
        }

        bool BeginMove()
        {
            lomoSys.SetActive(true);
            return true;
        }
        
        void Sing(InputAction.CallbackContext obj)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = Resources.Load<AudioClip>("audio/啊1");
                audioSource.Play();
            }
            tapA = true;
        }

        // Start is called before the first frame update
        void Start()
        {
            lomoSys.SetActive(false);
            singSongInputAction.action.performed += Sing;
            // Register all demanding audio files
            dialogs = new List<Dialog>();
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"01"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"02"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"03"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"04"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"05"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"06"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"07"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"08"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"09"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"10"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"11"), Dialog.Type.ACTION, SingSong));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"12"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"13"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"14"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"15"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"16"), Dialog.Type.COMMON));
            dialogs.Add(new Dialog(Path.Combine(AUDIOS_PATH,"17"), Dialog.Type.ACTION, BeginMove));
            
            // Initialize dialogs
            InitializeDialogs(dialogs);

            // Initialize single audio source component
            audioSource = GetComponent<AudioSource>();

            // Play all dialogs.
            PlayDialogs();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void PlayDialogs()
        {
            // Reset
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            StartCoroutine(WaitForDialogEnd());
        }

        private IEnumerator WaitForDialogEnd()
        {
            yield return new WaitWhile(()=> audioSource.isPlaying || dialogs[dialogCuror].isRunning);

            Debug.Log(""+ audioSource.isPlaying + dialogs[dialogCuror].isRunning );

            NextDialog();
        }

        private void NextDialog()
        {
            if (dialogCuror < dialogs.Count)
            {
                Dialog dialog = dialogs[dialogCuror];

                // Handle audio stuff
                PlayAudio(dialog.clip);

                // Checks whether this dialog belongs to action dialog.
                if (dialog.eventType == Dialog.Type.ACTION)
                {
                    dialog.isRunning = true;

                    // Job
                    StartCoroutine(ExecuteAction(dialog));
                }
                else
                {
                    dialogCuror++;
                }
                

                StartCoroutine(WaitForDialogEnd());
            }
        }

        IEnumerator ExecuteAction(Dialog dialog)
        {
            Debug.Log("Start action");

            yield return new WaitUntil(() => dialog.OnAction());

            Debug.Log("Stop action");
            dialog.isRunning = false;

            dialogCuror++;
        }

        private void PlayAudio(AudioClip clip)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            audioSource.clip = clip;

            audioSource.Play();
        }

        private void InitializeDialogs(List<Dialog> dialogs)
        {
        
            for (int i = 0; i < dialogs.Count; i++)
            {
                AudioClip clip = Resources.Load<AudioClip>(dialogs[i].audio);

                dialogs[i].clip = clip;
            }
    
        }
    }

}
