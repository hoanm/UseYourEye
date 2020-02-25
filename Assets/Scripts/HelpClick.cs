using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

using System;
using System.Globalization;

public class HelpClick : MonoBehaviour
{
    public Button btn;
	public AudioSource audio;

    // Update is called once per frame
    public void PlayAlarm(){
		Debug.Log ("You have clicked the Help button!");
		// Play an alarm signal
		audio = GetComponent<AudioSource>();
		audio.Play();
		// Need FIX: Play sound in 30s !
		//System.Threading.Thread.Sleep(30000);
		//audio.Pause();
	}

}
