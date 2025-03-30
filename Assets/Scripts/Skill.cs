using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Skill", order = 1)] 

public class Skill : ScriptableObject
{
    [SerializeField] private string skillName;
    [SerializeField] private string description;
    [SerializeField] private int cost;

    [SerializeField] private List<Skill> preRequisites = new List<Skill>();
    [SerializeField] private List<Skill> unlockeables = new List<Skill>();

    public string SkillName => skillName;
    public string Description => description;
    public int Cost => cost;
    public List<Skill> prerequisites => preRequisites;
    public List<Skill> Unlockables => unlockeables;
}
