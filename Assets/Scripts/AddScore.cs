using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour {

    public int value;
    public Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().FindScore(value);
        }
    }
}
