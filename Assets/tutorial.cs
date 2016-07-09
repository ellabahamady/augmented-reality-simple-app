using UnityEngine;
using System.Collections;

public class tutorial : MonoBehaviour {
	public GUISkin MySkin;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI(){
		float btnWidth = 200;
		float btnHeight = 45;
		float btnSpace = 50;
		float btnLeft = (Screen.width / 2) - 100;
		float btnTop = 400;
		GUI.skin = MySkin;
		if (GUI.Button(new Rect(btnLeft,btnTop,btnWidth,btnHeight),"Back"))
		{
			Application.LoadLevel("MainMenu");
		}
		
	}
}

