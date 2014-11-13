using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour {

	public GameObject parents;
	public float MinVal;
	public float MaxVal;
	public float CurVal;

	public void ResetValues()
	{
		this.GetComponent<Slider> ().value = CurVal;
		this.GetComponent<Slider> ().minValue = MinVal;
		this.GetComponent<Slider> ().maxValue = MaxVal;
	}

	// Use this for initialization
	void Start () {

	}	
	// Update is called once per frame
	void Update () {
		Vector3 wantedPos = Camera.main.WorldToScreenPoint (parents.transform.position);
		wantedPos = new Vector3 (wantedPos.x, (wantedPos.y + (Screen.height/10))+15f, wantedPos.z);
		transform.position = wantedPos;	

		this.GetComponent<Slider> ().value += Time.deltaTime;
	
		if (this.GetComponent<Slider> ().value == this.GetComponent<Slider> ().maxValue)
		{
			this.gameObject.SetActive(false);
		} 
		else 
		{
			this.gameObject.SetActive(true);
		}
	
	}
}
