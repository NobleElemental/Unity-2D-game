/*
 *source file name: playerController.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: changed border values, added header comments, added bullet travel and shoot feature
 */

using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	
	//add bullet
	[SerializeField]
	GameObject bullet;
	[SerializeField]
	GameObject BulletPosition;

	[SerializeField]
	private float speed = 0;

	private Transform _transform;
	private Vector2 _currentPosition;
	private float inputX;
	private float inputY;

	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//shoot bullet https://www.youtube.com/watch?v=2WlY0dL5Qrg
		if (Input.GetKeyDown ("m")) {
			GameObject Bullet = (GameObject)Instantiate (bullet);
			Bullet.transform.position = BulletPosition.transform.position;
		}

		inputX = Input.GetAxis ("Horizontal");
		inputY = Input.GetAxis ("Vertical");
		_currentPosition = _transform.position;

		if (inputX > 0) {
			_currentPosition += new Vector2 (speed, 0);
		}

		if (inputX < 0) {
			_currentPosition -= new Vector2 (speed, 0);
		}

		if (inputY > 0) {
			_currentPosition += new Vector2 (0, speed);
		}

		if (inputY < 0) {
			_currentPosition -= new Vector2 (0, speed);
		}

		checkBounds ();
		_transform.position = _currentPosition;
	
	}

	private void checkBounds(){

		if(_currentPosition.x < -39.35f){
			_currentPosition.x = -39.35f;
		}
		if(_currentPosition.x >-31f){
			_currentPosition.x = -31f;
		}

		if(_currentPosition.y < -1.5f) {
			_currentPosition.y = -1.5f;
		}

		if (_currentPosition.y > 1.5f) {
			_currentPosition.y = 1.5f;
		}
	}
}
