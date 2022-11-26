using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Support : Character
{
    private void Awake()
    {
        Name = "SUPPORT NAME";
        BaseHealth = 75;
        AttackDamage = 60;
        Experience = 1800;
        CritPercent = 100;
    }
    
    public override void SimulateCharacter()
    {
        base.SimulateCharacter();
        base.IntroduceCharacter();
        Debug.Log($"I am a Support Character");
        base.BuffPlayer(100,50);
    }
}
