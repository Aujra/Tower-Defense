﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Base_Tower : MonoBehaviour {

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
	}
	
	// Update is called once per frame
	public void Update () {
	
		if (InRangeTargets.Count > 0)
		{
			foreach (GameObject spell in Spells) 
			{
				if (spell.GetComponent<BaseSpell> ().IsReady () && !IsCasting) 
				{
					Debug.Log (spell.name + " IS READY  AM I CASTING " + IsCasting);
					spell.GetComponent<BaseSpell>().CastSpell();
				}
			}
		}
	}

	public abstract void Cast();
	public abstract void DealDamage();

}