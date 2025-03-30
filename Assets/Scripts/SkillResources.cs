using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/SkillResources", order = 2)]

public class SkillResources : ScriptableObject
{
    [SerializeField] List<Skill> skills = new List<Skill>();
    public List<string> GetSkillNames()
    {
        List<string> names = new List<string>();
        foreach (Skill skill in skills)
        {
            if (skill != null)
            {
                names.Add(skill.SkillName);
            }
        }
        return names;
    }
}
