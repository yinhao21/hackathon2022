using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigDected : MonoBehaviour
{
    [SerializeField] private AudioSource echo_source;
    [SerializeField] private GameObject audio_foot;
    private Vector3 orignPos;
    private float obj_position_z;
    private AudioSource footstep;
    // Start is called before the first frame update
    void Start()
    {
        orignPos = this.transform.position;
        obj_position_z = this.transform.position.z;
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
    }
    
    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("Enermy") && obj.gameObject.name.Contains("bee"))
        {
            echo_source.clip = Resources.Load<AudioClip>("arrow");
            echo_source.volume = 0.9f;
            echo_source.Play();
            this.transform.position = orignPos;
        }
    }
}
