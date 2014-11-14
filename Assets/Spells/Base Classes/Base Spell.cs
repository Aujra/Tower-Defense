using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class BaseSpell : MonoBehaviour {

	public int id;
	public int priority;

	public GameObject MyCastBar;

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
	public GameObject CastParticles;

	public int MinDamage;
	public int MaxDamage;
	public int CritChance;
	public float CritMultiplier;
	public int AllowedTargets;
	public DamageType Damage_Type;

	public float AttackSpeed;
	public float CastTime;
	public float Cooldown;
	public List<GameObject> OnHitEffects = new List<GameObject>();
	public List<GameObject> OnCriticalEffects = new List<GameObject>();

	private GameObject CombatText;

	public int Cost;

	public float CastDone;

	public abstract void OnHit ();
	public abstract void OnCritical();
	public abstract void DealDamage ();
	public abstract void CastSpell();

	private bool DidWeCritical;

	public Base_Tower MyTower;

	//Spell Ready Variables
	public float nextAttack;

	public bool OnGCD = true;

	public bool IsReady()
	{
		return Time.time > nextAttack;
	}

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
		description = "Deals " + MinDamage + "-" + MaxDamage + " " + Damage_Type + " damage to " + AllowedTargets + " enemies";
		nextAttack = 0f;
	}
	
	// Update is called once per frame
	public void Update () {
		if (Time.time > (CastDone) && MyTower != null && CastTime > 0) {
			MyTower.IsCasting = false;
				}
	}
}
