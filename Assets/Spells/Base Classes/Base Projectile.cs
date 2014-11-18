using UnityEngine;
using System.Collections;

public class BaseProjectile : MonoBehaviour {

	public float speed;
	public GameObject target;

	// Use this for initialization
	public void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
	}
}
