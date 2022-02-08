using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager
{
        public void LoadNextLevel()
        {

        }
}
public interface IQuestManager
{
    int TotalQuest { get; set;}
    int CompletedQuest { get; set;}
    
    void GenerateQuest(int TotalQuest);
    void QuestCompleted();
    void QuestInstantiation();
    void QuestCondition();
    void EvaluteQuest();
    void AllQuestCompleted();
}
public class QuestSystem
{
    public void QuestCondition()
    {

    }
    
}
public interface GoalManager
{   
    /*
    Amount Of Required Goal
    Amount Of Completed Goal
    Method to define description and logic of Goal
    Method To Evaluate if Goal is completed
    Method to Evaluate Amount of Completed Goal
    Method to Tell Quest Manager about Goal Completion*/
}

