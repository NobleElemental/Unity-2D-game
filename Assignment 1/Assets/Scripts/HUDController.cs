/*
 *source file name: HUDController.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 30, 2016
 *Revision History: added header comments
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {

	[SerializeField]
	Text scoreLabel = null;
	[SerializeField]
	Text healthLabel = null;


	[SerializeField]
	Button restartBtn = null;
	[SerializeField]
	Text gameOverLabel = null;
	[SerializeField]
	GameObject player = null;
	[SerializeField]
	Text highScore = null;


	public void UpdateScore(){
		scoreLabel.text = "Score: " + Player.Instance.Score;
	}

	public void UpdateHealth(){
		healthLabel.text = "Health: " + Player.Instance.Health; 
	}

	//start the game
	void Start(){

		scoreLabel.text = "Score: 0";
		healthLabel.text = "Health: 100";
		Player.Instance.hud = this;
		restartGame ();
	}

	void Update(){

	}


	public void gameOver(){
		//hide labels
		scoreLabel.gameObject.SetActive (false);
		healthLabel.gameObject.SetActive (false);

		//stop player from controlling ship
		player.SetActive(false);

		//show game over UI
		gameOverLabel.gameObject.SetActive(true);
		highScore.gameObject.SetActive (true);
		highScore.text = "Highscore: " + Player.Instance.HighScore;

		//show restart button
		restartBtn.gameObject.SetActive(true);

	}

	public void restartGame(){

		//show health and score UI
		scoreLabel.gameObject.SetActive(true);
		healthLabel.gameObject.SetActive (true);
		Player.Instance.Score = 0;
		Player.Instance.Health = 100;
		highScore.gameObject.SetActive (false);

		//allow player to take control of ship
		player.SetActive(true);

		//high game over UI
		gameOverLabel.gameObject.SetActive(false);
		restartBtn.gameObject.SetActive (false);
	}
		
		
}

