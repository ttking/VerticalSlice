using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Skills
{
    NormalAttack,
    Defend,
    Starlight

}

public class SkillData {

    private Dictionary<Skills, float> actionTimeData = new Dictionary<Skills, float>();

    private string name;
    private Skills skill;
    private float skillTime;

    public SkillData(string name, Skills skill, float skillTime)
    {
        this.name = name;
        this.skill = skill;
        this.skillTime = skillTime;
    }

    public string Name
    {
        get {return name; }
    }

    public Skills Skill
    {
        get { return skill; }
    }

   
}
