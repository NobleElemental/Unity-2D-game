/*
 *source file name: playerCollider.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: changed code to make it more shorter, added sounds, added header comments
 */

using UnityEngine;
using System.Collections;

public class playerCollider : MonoBehaviour {

	[SerializeField]
	GameObject explosion = null;

	//lose 15 health when touched by big ship
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "enemyBig") {
			Debug.Log ("collision with enemy big ship");
			Player.Instance.Health -= 15;

		}

		//lose 10 health when touched by small ship
		if (other.gameObject.tag == "enemySmall") {
			Debug.Log ("Collision with enemy small ship");
			Player.Instance.Health -= 10;

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
		}

		//gain 10 points when gem is collected
		 if (other.gameObject.tag == "gem") {
			Debug.Log ("collision with gem");
				Player.Instance.Score += 20;
				gemController gem1 = other.gameObject.GetComponent<gemController> ();
				gem1.Reset ();
		}	
	}
}
