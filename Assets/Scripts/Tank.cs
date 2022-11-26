using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Character
{
    
    private void Awake()
    {
        Name = "TANK NAME";
        BaseHealth = 200;
        AttackDamage = 50;
        Experience = 2250;
        CritPercent = 50;
    }
    public override void SimulateCharacter()
    {
        base.SimulateCharacter();
        base.IntroduceCharacter();
        Debug.Log($"I am a Tank Character");
        Skill();
    }

    public override void Skill()
    {
        base.BaseHealth = BaseHealth * 2;
        Debug.Log($"Health is now {BaseHealth}");
    }
}
