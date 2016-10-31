/*
 *source file name: backgroundController.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: added main script, added header comments
 */

using UnityEngine;
using System.Collections;

public class backgroundController : MonoBehaviour {

	[SerializeField]
	private float speed = 0;

	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}

	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -39.73f) {
			Reset ();
		}
	}

	private void Reset(){

		_currentPosition = new Vector2 (-20.53f, 0);
		_transform.position = _currentPosition;
	}
}
