using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {
    public AudioMixer mainMixer;

    public void SetMusic(float vol) {
        mainMixer.SetFloat("musicVol", vol);
    }
    public void SetSFX(float vol) {
        mainMixer.SetFloat("sfxVol", vol);
    }
}