using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomTextDisplay : MonoBehaviour
{
    public Text displayText;  // UI Text component to display the messages
    private List<string> motivationalTexts = new List<string>
    {
        "Never Give Up",
        "Stay Strong!",
        "Persist..",
        "Keep Fighting!",
        "Stay Determined",
        "Push Through!",
        "Hold On..",
        "Keep Going!",
        "Keep the Faith.",
        "Stay Resilient..",
        "One More Step..",
        "Never Surrender!",
        "Endure the Storm..",
        "Keep Climbing.",
        "Stay Focused..",
        "Don't Quit!",
        "Keep Believing.",
        "Just Do It!"
    };
    private float elapsedTime = 0f;
    private float defaultFontSize;

    private void Start()
    {
        defaultFontSize = displayText.fontSize;  // Store the default font size
        StartCoroutine(DisplayRandomText());
    }

    private IEnumerator DisplayRandomText()
    {
        while (true)
        {
            var randomIndex = Random.Range(0, motivationalTexts.Count);
            displayText.text = motivationalTexts[randomIndex];


            yield return new WaitForSeconds(1.5f);
            displayText.text = "";

            switch (elapsedTime)
            {
                case < 30f:
                    yield return new WaitForSeconds(3.5f);  // 5 seconds interval - 1.5 seconds display time
                    break;
                case < 50f:
                    yield return new WaitForSeconds(1.5f);  // 3 seconds interval - 1.5 seconds display time
                    break;
                case < 70f:
                case < 90f:
                case <= 90f:
                    yield return new WaitForSeconds(0.5f);  // 2 seconds interval - 1.5 seconds display time
                    break;
            }

            elapsedTime += 5f;  // Increment elapsed time based on the overall cycle time
        }
    }
}