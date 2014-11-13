// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;

public class RTS_Camera : MonoBehaviour {
	public float CamSpeed= 1.00f;
	public float GUIsize= 25;
	
	void  Update (){
		Rect recdown= new Rect(0, 0, Screen.width, GUIsize);
		Rect recup= new Rect(0, Screen.height-GUIsize, Screen.width, GUIsize);
		Rect recleft= new Rect(0, 0, GUIsize, Screen.height);
		Rect recright= new Rect(Screen.width-GUIsize, 0, GUIsize, Screen.height);
		
		if (recdown.Contains(Input.mousePosition))
			transform.Translate(0, 0, -CamSpeed, Space.World);
		
		if (recup.Contains(Input.mousePosition))
			transform.Translate(0, 0, CamSpeed, Space.World);
		
		if (recleft.Contains(Input.mousePosition))
			transform.Translate(-CamSpeed, 0, 0, Space.World);
		
		if (recright.Contains(Input.mousePosition))
			transform.Translate(CamSpeed, 0, 0, Space.World);
	}
}