/*
 *source file name: bulletController.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: added header comments, added trigger for small and big ships
 */


using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {

	//for trigger
	[SerializeField]
	GameObject explosion = null;

	//make the bullet move https://www.youtube.com/watch?v=2WlY0dL5Qrg
	[SerializeField]
	private float speed = 0;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		_currentPosition = transform.position;
		_currentPosition += new Vector2 (speed, 0);
		transform.position = _currentPosition;

		if (_currentPosition.x > -30.5) {
			Destroy (gameObject);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "enemySmall") {
			Player.Instance.Score += 5;
			enemySmallController sp = other.gameObject.GetComponent<enemySmallController> ();
			if (sp != null) {
				GameObject ex = Instantiate (explosion);
				ex.transform.position = sp.transform.position;
				sp.Reset ();

				AudioSource asrc = gameObject.GetComponent<AudioSource> ();
				if (asrc != null) {
					asrc.Play ();
				}
			}
			Destroy (gameObject);
		} else if (other.gameObject.tag == "enemyBig") {
			Destroy (gameObject);
		}
	}
}
