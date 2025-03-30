using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Anthonycrimson.GameUtils;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }

    public Skill skill1;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #region references
    [SerializeField] SkillResources skillResources;
    [SerializeField] SkillManager skillManager;
    #endregion

    #region setting
    [SerializeField] private string _name = "Antonio";
    #endregion

    #region getters
    public string Name => _name;
    #endregion
    void Start()
    {
        FindPrerequisites(skill1);
    }
    public void HolaMundo()
    {
        print("Hola");
    }
    public void FindPrerequisites(Skill skill)
    {
        skillManager.SearchPrerequisites(skill);
    }
}
