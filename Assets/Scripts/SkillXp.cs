using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class SkillXp : MonoBehaviour
{
    public int currentLevel;
    public int xpRequired;
    public int currentXp;
    public void Set (int level)
    {
        currentLevel = level;
        xpRequired = (level + 2) * 3;
        currentXp = 0;
    }
    public void Add(int xp, out bool levelup)
    {
        levelup = false;
        if((currentXp += xp) >= xpRequired)
        {
            Set(currentLevel ++);
            levelup = true;
        }
    }   
}
