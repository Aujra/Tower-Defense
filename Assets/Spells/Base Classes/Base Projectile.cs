using UnityEngine;
using System.Collections;

public class BaseProjectile : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
