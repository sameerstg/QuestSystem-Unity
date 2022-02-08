using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour, IQuestManager
{
    //      Setting For New Level
    [Header("Setting For Level")]
    //      Total Number Of Level
    public int totalQuest = 3;
    //      Completed Level
    int completedQuests;
    //      List of Quest Names
    public string[] questNames;
    //      List of Quest Description
    [TextArea]
    public string[] questDescription;
    //      Array of Bool for Quest Array
    public bool[] isQuestCompleted;



    //      Interface Properties Getter and Setter
    public int TotalQuest { get => totalQuest; set => totalQuest = value; }
    public int CompletedQuest { get => completedQuests; set => completedQuests = value; }
    //      Method To be called from inspector
    [ContextMenu("QuestInstantiation")]
    public void QuestInstantiation()
    {
        GenerateQuest(TotalQuest);
    }
    //      Instantiating Quests Array
    public void GenerateQuest(int TotalQuest)
    {
         questNames =  new string[TotalQuest];
         questDescription =  new string[TotalQuest];
        isQuestCompleted = new bool[TotalQuest];
        QuestCondition();

    }
    
    //      Evaluating If All Quest are done
    public void EvaluteQuest()
    {
        if (CompletedQuest >= TotalQuest)
        {
            AllQuestCompleted();
        }
    }
    //      Called After Each Quest Completion
    public void QuestCompleted()
    {
        CompletedQuest += 1;
        EvaluteQuest();
    }
    //      Called after completion of All Quest
    public void AllQuestCompleted()
    {
        throw new System.NotImplementedException();
    }

    public void QuestCondition()
    {
        if (!isQuestCompleted[0])
        {
            if (false)
            {
                QuestCompleted();
                isQuestCompleted[0] = true;
            }
        }
    }
}
