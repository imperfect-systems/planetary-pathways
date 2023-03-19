using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        string stage = PlayerPrefs.GetString("planet");
        string bgPath = $"backgrounds/background-{stage}";
        string musicPath = $"music/music-{stage}";
        SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>(bgPath);
        AudioSource audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>(musicPath);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
