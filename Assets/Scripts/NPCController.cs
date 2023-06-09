using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public static int npcScore = 10;
    public float speed = 2.0f;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Define AI behavior for the characters
    void Update()
    {
       Vector3 direction = (playerTransform.position - transform.position).normalized;
       transform.position += direction * speed * Time.deltaTime;
       
    }

     void OnGUI()
    {
        GUIStyle NPCscoreStyle = new GUIStyle();
        NPCscoreStyle.fontSize = 24;
        NPCscoreStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 40, 200, 50), "NPC Score: " + npcScore, NPCscoreStyle);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Cube")) {
            other.gameObject.SetActive(false);
            UpdateNPCScore();
        }
    }

    void UpdateNPCScore(){
        npcScore--;
    }
}
