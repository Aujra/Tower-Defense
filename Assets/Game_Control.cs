using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game_Control : MonoBehaviour {

	public bool Building;

	public LayerMask PlanesMask;

	public GameObject LastHitPlane;

	public Shader Highlighted;
	public Shader NotHighlighted;

	public GameObject BaseTower;
	public GameObject CastBar;

	public GameObject SelectedTower;

	public List<GameObject> slider = new List<GameObject>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {	

		if (LastHitPlane != null) {
			LastHitPlane.renderer.material.shader = NotHighlighted;
		}

		if (Building) {
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit rayhit;						
						if (Physics.Raycast (ray, out rayhit, 1000, PlanesMask)) {
								LastHitPlane = rayhit.collider.gameObject;
								LastHitPlane.renderer.material.shader = Highlighted;
						}
				if (Input.GetMouseButton(0) && LastHitPlane != null)
			{
				BuildOrSelectTower();
			}

				} else {

				}
	}

	public void BuildOrSelectTower()
	{
		if (LastHitPlane.tag == "Open Plane") 
		{
			GameObject TempTower = Instantiate(BaseTower, LastHitPlane.transform.position, Quaternion.identity) as GameObject;
			GameObject TempSlider = Instantiate(CastBar, LastHitPlane.transform.position, Quaternion.identity) as GameObject;
			TempSlider.GetComponent<test>().parents = TempTower;
			TempSlider.transform.parent = GameObject.FindGameObjectWithTag("CastBar Canvas").transform;
			TempTower.GetComponent<Base_Tower>().MyCastBar = TempSlider;
			LastHitPlane.tag = "Closed Plane";
		}
	}

	public void ToggleBuilding()
	{
		Building = !Building;
		Debug.Log ("BUILDING " + Building);
	}

}
