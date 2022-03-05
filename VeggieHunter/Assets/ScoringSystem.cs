using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public int point = 50;
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore = theScore + point;
        scoreText.GetComponent<Text>().text = "Score:   " + theScore;
        Destroy(gameObject);
    }
}
