using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Skills", order = 1)] 

public class Skill : ScriptableObject
{
    [SerializeField] private string skillName;
    [SerializeField] private string description;
    [SerializeField] private int cost;

    private List<Skill> preRequisites = new List<Skill>();

    public string SkillName => skillName;
    private string Description => description;
    private int Cost => cost;
}
