using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterData : MonoBehaviour {

    private List<SkillData> skills = new List<SkillData>();

    //Personal Stats
    
    public float health;
    public float mana;
    private float defense;
    private float magicDefense;
    private float attackPower;
    private float spellPower;
    private float criticalChance;
    private float dodgeChance;
    private float speed;

    private float remainingTimeForAction;

    public float RemainingTimeForAction
    {
        get { return remainingTimeForAction; }
    }

	void Start () {
        SkillData normalAttack = new SkillData("Normal Attack", Skills.NormalAttack, 1f);
        AddSkill(normalAttack);
        SkillData defend = new SkillData("Defend", Skills.Defend, 1f);
        AddSkill(defend);
        Debug.Log(skills[0].Skill);
	}

    public void AddSkill(SkillData skill)
    {
        skills.Add(skill);
    }
    
}
