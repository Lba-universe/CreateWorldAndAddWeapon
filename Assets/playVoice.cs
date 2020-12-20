using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playVoice : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            if(audioSource.isPlaying==false)
                audioSource.Play();
           


        }
        else
        {
            audioSource.Stop();
        }

    }
}
