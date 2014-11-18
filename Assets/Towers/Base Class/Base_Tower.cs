using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Base_Tower : MonoBehaviour {

	public List<GameObject> SpellList = new List<GameObject>();
	public List<GameObject> Spells = new List<GameObject>();

	public List<Base_Enemy> InRangeTargets = new List<Base_Enemy>();
	public List<Base_Enemy> PreferedTargets = new List<Base_Enemy> ();

	public GameObject MyCastBar;

	public bool IsCasting;

	// Use this for initialization
	public void Start () {
		//Initialize the spells
		foreach (GameObject spell in SpellList) 
		{
			GameObject tempSpell = Instantiate(spell, transform.position, Quaternion.identity) as GameObject;
			tempSpell.name = spell.name + "_" + Random.Range(1,100);
			tempSpell.transform.parent = this.transform;
			tempSpell.GetComponent<BaseSpell>().nextAttack = 0f;
			tempSpell.GetComponent<BaseSpell>().MyCastBar = MyCastBar;
			tempSpell.GetComponent<BaseSpell>().MyTower = this;
			Spells.Add(tempSpell);
		}
		//SORT BY PRIORITY IN ROTATION
		Spells.Sort((spell1, spell2) => spell2.GetComponent<BaseSpell>().priority.CompareTo(spell1.GetComponent<BaseSpell>().priority));
	}
	
	// Update is called once per frame
	public void Update () {
	
		if (InRangeTargets.Count > 0)
		{
			foreach (GameObject spell in Spells) 
			{
				if (spell.GetComponent<BaseSpell> ().IsReady () && !IsCasting) 
				{
					spell.GetComponent<BaseSpell>().Target = InRangeTargets[0].gameObject;
					spell.GetComponent<BaseSpell>().CastSpell();
				}
			}
		}
	}

	public virtual void Cast()
	{

	}
	public virtual void DealDamage()
	{

	}

}
