using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public AudioClip collectedClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        OctoController controller = other.GetComponent<OctoController>();

        if (controller != null)
        {
            controller.ChangeScore(1);
            controller.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
