using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 12f;
    Text timerText;
    public Text loseText;

    public AudioClip loseClip;
    AudioSource audioSource;

    private OctoController octoController;
    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
        GameObject octoControllerObject= GameObject.FindWithTag("OctoController");
        audioSource = GetComponent<AudioSource>();
        loseText.text = "";

        if (octoControllerObject != null)
        {
            octoController = octoControllerObject.GetComponent<OctoController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = "Timer: " + Mathf.Round(timer);
        timer = Mathf.Clamp(timer, 0f, 12f);

        if (octoController.score == 4)
        {
            Destroy(gameObject);
        }

        if (timer == 0)
        {
            if (octoController.score < 4)
            {
                loseText.text = "You Lose!";
                octoController.speed = 0.0f;
                
            }
        }

    }
    
}
