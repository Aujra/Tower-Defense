using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spell_Fire_Blast : BaseSpell {

	// Use this for initialization
	void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}

	public override void CastSpell()
	{
		nextAttack += CastTime;
		nextAttack += AttackSpeed;
		nextAttack += Cooldown;
		MyCastBar.GetComponent<Slider> ().minValue = Time.time;
		MyCastBar.GetComponent<Slider> ().maxValue = Time.time + CastTime + AttackSpeed;
		MyCastBar.SetActive (true);
		CastDone = Time.time + 1f;
	}
	
	public override void OnHit()
	{
		
	}
	public override void OnCritical()
	{
		
	}
	public override void DealDamage()
	{
		
	}

	public override void FireProjectile()
	{

	}
}
