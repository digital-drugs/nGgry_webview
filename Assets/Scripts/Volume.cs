using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private Slider _volumeSlider;

    void Awake()
    {
        _volumeSlider.onValueChanged.AddListener(Set);
        _audioSource = GetComponent<AudioSource>();
         

        if (PlayerPrefs.HasKey("volume"))
        {
            _audioSource.volume = PlayerPrefs.GetFloat("volume");
        }
        else
        {
            PlayerPrefs.SetFloat("volume", _audioSource.volume);
        }
        _volumeSlider.value = _audioSource.volume;

    }

    private void Set(float value)
    {
        _audioSource.volume = value;
        PlayerPrefs.SetFloat("volume", value);
    }

    private void OnDisable()
    {
        _volumeSlider.onValueChanged.RemoveListener(Set);
    }
}
