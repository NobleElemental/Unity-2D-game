/*
 *source file name: Player.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 29, 2016
 *Revision History: added header comments
 */

using UnityEngine;
using System.Collections;

public class Player  {

	private const string key ="HIGH_SCORE";

	public HUDController hud; 

	private static Player _instance = null;
	public static Player Instance{
		get{
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}
	}

	private Player(){
		if (PlayerPrefs.HasKey (key)){
			_highScore = PlayerPrefs.GetInt (key);
		}
	}

	private int _highScore = 0;

	public int HighScore{
		get{
			return _highScore;
		}
	}

		
	private int _score = 0;

	public int Score {
		get{
			return _score;
		}
		set{
			_score = value;
			hud.UpdateScore();
			if (value > _highScore) {
				PlayerPrefs.SetInt (key, value);
				_highScore = value;
			}
		}
	}

	private int _health = 100;

	public int Health{
		get{
			return _health;
		}
		set{
			_health = value;
			hud.UpdateHealth();
			hud.UpdateHealth ();
			if (_health <= 0) {
				hud.gameOver ();
			}
		}
	}
}