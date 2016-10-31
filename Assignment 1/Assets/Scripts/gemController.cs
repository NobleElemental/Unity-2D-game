/*
 *source file name: gemController.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: added onTrigger for audio, changed position values, added header comments
 */

using UnityEngine;
using System.Collections;

public class gemController : MonoBehaviour {

	[SerializeField]
	private float speed = 0;

	private Transform _transform;
	private Vector2 _currentPosition;

	private float minY = -1.45f;
	private float maxY = 1.45f;

	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;
		Reset();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -40) {
			Reset ();
		}
	
	}

	public void Reset(){
		float xPos = Random.Range (-30.4f, -25f);
		float yPos = Random.Range (minY, maxY);
		_currentPosition = new Vector2 (xPos, yPos);
		_transform.position = _currentPosition;

	}

	//gem trigger
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "player"){

		//play sound when player gets gem
		AudioSource asrc = gameObject.GetComponent<AudioSource> ();
			if (asrc != null) {
				asrc.Play ();

			}
		}
	}


		
}
