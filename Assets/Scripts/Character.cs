using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    //3+ private properties which derive their value by initializing in the constructor.
    private string _name;
    private float _baseHealth;
    private float _attackDamage;
    private float _experience;
    private float _critPercent;

    protected string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "Default" : value;
    }

    protected float BaseHealth
    {
        get => _baseHealth;
        set => _baseHealth = (0 >= (value)) ? 100 : value;
    }
    
    protected float AttackDamage
    {
        get => _attackDamage;
        set => _attackDamage = (0 >= (value)) ? 50 : value;
    }
    
    protected float Experience
    {
        get => _experience;
        set => _experience = value;
    }
    
    protected float CritPercent
    {
        get => _critPercent;
        set => _critPercent = value;
    }


    //3 public properties with set computation

    public float Level => (int)(Math.Floor(_experience / 1000));
    public float MaxHealth => _baseHealth + (int)(_baseHealth * (Level/2));
    public float CritDamage => _attackDamage + (_attackDamage * (_critPercent/100) );
    

    //3+ functions

    public virtual void SimulateCharacter()
    {
        Debug.Log($"Simulating {_name}");
    }

    public virtual void IntroduceCharacter()
    {
        Debug.Log($"Hello I am {_name}, I have {_baseHealth} Health and {MaxHealth} Max Health. With {_attackDamage} attack damage and {CritDamage} Crit DMG. With {_experience} exp points at Level {Level}");
    }
    
    public virtual void NormalAttack()
    {
        Debug.Log($"Initiating normal Attack");
        Debug.Log($"dealt {_attackDamage} damage to opponent");
    }

    public virtual void Skill()
    {
        Debug.Log($"Initiating skill");
    }
    

    public virtual void BuffPlayer(float attackBuff)
    {
        Debug.Log($"Buffing ATK of character");
        _attackDamage += attackBuff;
        Debug.Log($"Attack Damage is now {_attackDamage}");
    }
    
    public virtual void BuffPlayer(float attackBuff, float critBuff)
    {
        Debug.Log($"Buffing ATK and CRITDMG of character");
        _attackDamage += attackBuff;
        Debug.Log($"Attack Damage is now {_attackDamage} and Critical Damage is now {CritDamage + critBuff}");
    }

    
}
