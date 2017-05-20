using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class barkscript : MonoBehaviour
{

    public AudioClip Bark1;
    public AudioClip Bark2;


    // Use this for initialization
    void Start()
    {




    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dog"))
        {
            other.gameObject.SetActive(false);
            AudioSource audio = GetComponent<AudioSource>();
            //yield return new WaitForSeconds(audio.clip.length);
            audio.clip = Bark1;
            audio.Play();

        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}
