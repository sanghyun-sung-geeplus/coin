using UnityEngine;
using System.Collections;

public class Remover2 : MonoBehaviour {
	
	public AudioClip oneup;
	AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
		Score.score += 3;
		audio.PlayOneShot(oneup);
    }
}
