using UnityEngine;
using System.Collections;

public class RangeHelper : MonoBehaviour {

	public void OnTriggerEnter(Collider c)
	{
		Debug.Log (c.gameObject);
		if (c.gameObject.tag == "Enemy") 
		{
			this.GetComponentInParent<Base_Tower> ().InRangeTargets.Add (c.gameObject.GetComponent<Base_Enemy> ());
		}
	}

	public void OnTriggerExit(Collider c)
	{
				if (c.gameObject.tag == "Enemy") {
						this.GetComponentInParent<Base_Tower> ().InRangeTargets.Remove (c.gameObject.GetComponent<Base_Enemy> ());
				}
		}

}
