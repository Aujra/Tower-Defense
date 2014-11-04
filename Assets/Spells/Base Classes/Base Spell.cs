using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class BaseSpell : MonoBehaviour {

	public enum DamageType
		{
		Physical,
		Fire,
		Lighting,
		Poison,
		Cold
		}

	public string name;
	public string description;

	public Sprite Icon;
	public GameObject ProjectileObject;

	public int MinDamage;
	public int MaxDamage;
	public int CritChance;
	public float CritMultiplier;
	public int AllowedTargets;
	public DamageType Damage_Type;

	public int AttackSpeed;
	public int CastTime;
	public int Cooldown;
	public List<GameObject> OnHitEffects = new List<GameObject>();
	public List<GameObject> OnCriticalEffects = new List<GameObject>();

	private GameObject CombatText;

	public int Cost;

	public abstract void OnHit ();
	public abstract void OnCritical();
	public abstract void DealDamage ();

	private bool DidWeCritical;

	public void RollForCritial()
	{
		DidWeCritical = Random.Range (0, 100) < CritChance;
	}

	//Reuseable Base Functions

	public void ApplyEffects(bool crit)
	{
	if (crit) 
		{
		
		} 
		else 
		{
		
		}
	}

	// Use this for initialization
	public void Start () {
		Debug.Log ("IN DESCRIPTION BASE");
		description = "Deals " + MinDamage + "-" + MaxDamage + " " + Damage_Type + " damage to " + AllowedTargets + " enemies";
	}
	
	// Update is called once per frame
	public void Update () {
	
	}
}
