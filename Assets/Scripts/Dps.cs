using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dps : Character
{
    private void Awake()
    {
        Name = "DPS NAME";
        BaseHealth = 100;
        AttackDamage = 200;
        Experience = 1250;
        CritPercent = 187;
    }

    public override void SimulateCharacter()
    {
        base.SimulateCharacter();
        base.IntroduceCharacter();
        Debug.Log($"I am a DPS Character");
        base.BuffPlayer(100);
        base.NormalAttack();
    }
}
