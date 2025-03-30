using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    void Start()
    {
        LearnSkill(GameManager.instance.skill1);
    }
    void Update()
    {

    }
    Dictionary<Skill, SkillXp> SkillFreePlayer = new Dictionary<Skill, SkillXp>();
    public void LearnSkill(Skill skill)
    {
        SkillXp skillXp = new SkillXp();
        skillXp.Set(0);
        SkillFreePlayer.Add(skill, skillXp);
    }
    [Button]
    public void AddXp(int xp, Skill skill)
    {
        if (!SkillFreePlayer.TryGetValue(skill, out SkillXp value)) return;

        value.Add(xp, out bool levelup);

        if (!levelup) return;

        foreach (Skill skills in skill.Unlockables)
            LearnSkill(skills);
    }
}
