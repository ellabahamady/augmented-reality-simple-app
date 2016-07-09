using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin MySkin;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI(){
		float btnWidth = 200;
		float btnHeight = 35;
		float btnSpace = 40;
		float btnLeft = (Screen.width / 2) - 100;
		float btnTop = 320;
		GUI.skin = MySkin;
		if (GUI.Button(new Rect(btnLeft,btnTop,btnWidth,btnHeight),"Start"))
		{
			Application.LoadLevel("AR");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop+btnSpace,btnWidth,btnHeight),"Tutorial"))
		{
			Application.LoadLevel("tutorial");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop+(btnSpace*2),btnWidth,btnHeight),"About"))
		{
			Application.LoadLevel("about");
		}
		if (GUI.Button(new Rect(btnLeft,btnTop+(btnSpace*3),btnWidth,btnHeight),"Quit"))
		{
			Application.Quit();
		}
	}
}
