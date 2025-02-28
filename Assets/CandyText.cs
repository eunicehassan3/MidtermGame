using UnityEngine;
using TMPro;

public class CandyText : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
        string message  = "Candy Count: " + ClawBehavior.count;
        text.text = message.ToString();
    }
}