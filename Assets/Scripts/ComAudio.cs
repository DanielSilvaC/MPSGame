using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ComAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Comaudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
        DontDestroyOnLoad(gameObject);
    }
    public void Semaudio()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Stop();
    }
}
