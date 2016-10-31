/*
 *source file name: enemyBigController.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: changed position values, added header comments
 */


using UnityEngine;
using System.Collections;

public class enemyBigController : MonoBehaviour {

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

		if (_currentPosition.x <= -41) {
			Reset ();
		}

	}

	public void Reset(){
		float xPos = Random.Range (-30.77f, -29f);
		float yPos = Random.Range (minY, maxY);
		_currentPosition = new Vector2 (xPos, yPos);
		_transform.position = _currentPosition;

	}


}
