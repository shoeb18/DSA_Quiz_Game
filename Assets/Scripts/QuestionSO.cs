using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Quiz Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string questionText = "Enter the question here";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return questionText;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex; 
    }

    public string GetAnswerAtIndex(int index)
    {
        return answers[index];
    }
}
