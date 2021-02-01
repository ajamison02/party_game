using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayPlay : MonoBehaviour
{
    public AudioSource gameMusic;
    public AudioSource winClip;
    public AudioSource loseClip;

    private OctoController octoController;

    int score;
    int timer;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource backgroundMusic = gameObject.GetComponent<AudioSource>();
        backgroundMusic.PlayDelayed(2);



    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
