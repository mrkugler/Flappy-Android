using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour {

    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody rb;

    public AudioSource flySound;
    public AudioSource dieSound;
    public AudioSource hitSound;

    public GameObject Title;
    public GameObject PlayButton;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
            flySound.Play();
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        gameManager.GameOver();
        PlayButton.SetActive(true);
        Title.SetActive(true);
        hitSound.Play();
        dieSound.Play();
    }


}
