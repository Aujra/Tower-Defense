using UnityEngine;
using System.Collections;

public class Game_Control : MonoBehaviour {

	public LayerMask PlanesMask;

	public GameObject LastHitPlane;

	public Shader Highlighted;
	public Shader NotHighlighted;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit rayhit;

		if (LastHitPlane != null) 
		{
			LastHitPlane.renderer.material.shader = NotHighlighted;
		}

		if (Physics.Raycast (ray, out rayhit, 1000, PlanesMask)) 
		{
			LastHitPlane = rayhit.collider.gameObject;
			LastHitPlane.renderer.material.shader = Highlighted;
		}

	}
}
