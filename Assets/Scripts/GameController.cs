using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour

{
    public static int score = 0;

    void OnGUI()
    {
        GUIStyle scoreStyle = new GUIStyle();
        scoreStyle.fontSize = 24;
        scoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 200, 50), "Score: " + score, scoreStyle);
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Cube")) {
            UpdateScore();
            other.gameObject.SetActive(false);
        }
    }
    void UpdateScore(){
        score++;
    }


}
