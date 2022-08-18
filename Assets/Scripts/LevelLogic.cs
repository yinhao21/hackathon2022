using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator blackImage;
    public Animator moon;
    public Animator door;
    public AudioSource exitAudio;
    void Start()
    {
        door.SetBool("IsOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider obj)
    {
        print(obj.name);
        if (obj.CompareTag("Player"))
        {
            blackImage.Play("LevelChangeIng");
            moon.Play("LevelChange");
            StartCoroutine(AudioPlayFinished(3f));
        }
    }
    
    //执行协成函数 并且返回时间
    private IEnumerator AudioPlayFinished(float time)
    {   
        yield return new WaitForSeconds(2f);
        door.SetBool("IsOpen", true);
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex + 1);   // load next scene
    }
}
