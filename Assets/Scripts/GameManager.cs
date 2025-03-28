using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<GameObject> enemies = new List<GameObject>();
    #region references
    SkillResources skillResources;
    SkillManager skillManager;
    #endregion

    public void FindPrerequisites(Skill skill)
    {
        skillManager.SearchPrerequisites(skill);
    }
}
