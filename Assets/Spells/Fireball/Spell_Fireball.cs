using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spell_Fireball : BaseSpell {

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
		if (CastTime > 0) {
			CastDone = Time.time + CastTime;
				} else {
			CastDone = Time.time;		
		}
		MyCastBar.GetComponent<Slider> ().minValue = Time.time;
		MyCastBar.GetComponent<Slider> ().maxValue = Time.time + CastTime + AttackSpeed;
		MyCastBar.SetActive (true);
		MyTower.IsCasting = true;
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

}
