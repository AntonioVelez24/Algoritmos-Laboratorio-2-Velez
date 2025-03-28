using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Anthonycrimson.GameUtils;

public class SkillManager : MonoBehaviour
{
    public void SearchPrerequisites(Skill skill)
    {
        print("Nombre: " + skill.SkillName);
        if(skill.prerequisites.Count == 0)
        {
            return;
        }
        print("Se necesita: ");
        for (int i = 0; i <= skill.prerequisites.Count; ++i) 
        {
            SearchPrerequisites(skill.prerequisites[i]);
        }
    }   
}
