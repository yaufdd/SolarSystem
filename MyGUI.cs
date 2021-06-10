using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGUI : MonoBehaviour
{
    
    public static string head = "Солнечная система";
    public static string info = "Солнечная система полностью сформирована благодаря большому газопылевому облаку.";


    public GUIStyle style;

    private float timeScale;

    public Transform target;

    void OnGUI()
    {
        style.fontSize = 20;
        style.fontStyle = FontStyle.Bold;
        style.normal.textColor = Color.white;

        timeScale = GUI.HorizontalSlider(new Rect(10, 40, 150, 40), timeScale, -4, 4);
        Time.timeScale = Mathf.Exp(timeScale);

        
        GUI.Label(new Rect(10, 100, 100, 30), new GUIContent(head), style);
        GUI.Label(new Rect(10, 120, 400, 400), new GUIContent(info));
    }
}
