/*
 *source file name: mainMenu.cs
 *Name: John Cetin
 *Student Number: 100955200
 *last modified by: John Cetin
 *Date Last Modified: October 29, 2016
 *Revision History: added header comments
 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class mainMenu : MonoBehaviour {

	[SerializeField]
	Button startBtn = null;
	[SerializeField]
	Text titleLabel = null;

	//Unity 2D https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/creating-a-scene-menu
	public void LoadScene(int level){
		Application.LoadLevel (level);
	}
}
