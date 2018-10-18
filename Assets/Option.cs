using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {

    public bool isCorrect;

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }

        else
        {
            GetComponent<TextMesh>().color = Color.red;

            if (GetComponent<GameController>().realAnswerOption = GetComponent<GameController>().option1)
            {
                GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }
            if (GetComponent<GameController>().realAnswerOption = GetComponent<GameController>().option2)
            {
                GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }
            if (GetComponent<GameController>().realAnswerOption = GetComponent<GameController>().option3)
            {
                GetComponent<TextMesh>().color = new Color(17, 79, 47, 255);
            }
        }

    }

}
