using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OctoController : MonoBehaviour
{
    public float speed = 3.0f;

    public GameObject fruitPrefab;

    public int score = 0;
    public Text scoreText;
    public Text winText;

    Rigidbody2D rigidbody2d;
    Collider2D collider2d;
    float horizontal;
    float vertical;
    
    public AudioClip winClip;
    public AudioClip loseClip; 

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
        winText.text = "";
        scoreText.text = "Score: " + score.ToString();
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (score == 4)
        {
            winText.text = "You Win!";
            speed = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
       Vector2 position = transform.position;
       position.x = position.x + speed * horizontal * Time.deltaTime;
       position.y = position.y + speed * vertical * Time.deltaTime;

       rigidbody2d.MovePosition(position);
    }

    public void ChangeScore(int scoreAmount)
    {
        score = score + scoreAmount;
        scoreText.text = "Score: " + score.ToString();

        if (score == 4)
        {
            PlaySound(winClip);
        }
    }
    
}
