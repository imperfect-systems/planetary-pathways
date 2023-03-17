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
        SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>(bgPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
