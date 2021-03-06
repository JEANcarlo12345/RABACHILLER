using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    public Color startColor;

    private void Start()
    {
        startColor = GetComponent<Image>().color;
    }

    public void Answer()
    {
        if (isCorrect)
        {
            
            Debug.Log("Correcto");
            quizManager.correct();
        }
        else
        {
            
            Debug.Log("Incorrecto");
            quizManager.wrong();
        }
    }

}
