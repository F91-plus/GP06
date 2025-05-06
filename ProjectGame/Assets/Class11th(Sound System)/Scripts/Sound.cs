using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioManager audioManager;
    private float timer;

    private void Start()
    {
        audioManager.Listner(audioClip);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 5f)
        {
            audioManager.Listner(audioClip);
            timer = Random.Range(1, 6);
        }
        
    }
}
