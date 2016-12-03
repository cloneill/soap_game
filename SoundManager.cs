/*
 * Author: Luke O'Neill
 * 
 * Controls all the sounds in the game
 * 
 * NOTE: To have more than one audio clip playing back at the same time
 * there needs to be more than one audio source 
 * 
*/


using System.Collections;

using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    public AudioClip[] sfx_clips;       // Array of sound effect audio clips
    public GameObject start_mute_btn;   // Mute button game object for start screen
    public GameObject start_unmute_btn; // Unmute button game object for start screen
    public GameObject go_mute_btn;      // Mute button game object for game over screen
    public GameObject go_unmute_btn;    // Unmute button game object for game over screen
    public const int COIN_SFX = 0;      // Index position of coin sfx in sfx_clips array
    public const int TAIL_SFX = 1;      // Index position of tail grow sfx in sfx_clips array
    public const int CRASH_SFX = 2;     // Index position of avatar crash sfx in sfx_clips array

    private AudioSource sfx_source;     // The audio source that play the audio clips


    void Awake()
    {
        // Won't be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
        sfx_source = this.GetComponent<AudioSource>();
    }


    // Play the SFX audio
    public void playSFX(int index)
    {
        sfx_source.PlayOneShot(sfx_clips[index]);
    }


    // Turn on/off audio playback and display correct button
    public void setMuteState()
    {
        sfx_source.enabled = !sfx_source.enabled;

        bool btn_state = sfx_source.enabled;

        start_mute_btn.SetActive(btn_state);
        go_mute_btn.SetActive(btn_state);
        start_unmute_btn.SetActive(!btn_state);
        go_unmute_btn.SetActive(!btn_state);
    }
}


