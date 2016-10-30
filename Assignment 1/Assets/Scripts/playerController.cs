using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

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
	void Update () {

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

		if(_currentPosition.x < -38f){
			_currentPosition.x = -38f;
		}
		if(_currentPosition.x >-32.4f){
			_currentPosition.x = -32.4f;
		}

		if(_currentPosition.y < -1.45f) {
			_currentPosition.y = -1.45f;
		}

		if (_currentPosition.y > 1.45f) {
			_currentPosition.y = 1.45f;
		}
	}
}
