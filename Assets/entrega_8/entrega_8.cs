using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class entrega_8 : MonoBehaviour
{
    public TextMeshProUGUI sumText;
    private int sum;
    private int currentNumber;

    void Start()
    {
        sum = 0;
        currentNumber = 1;
        StartCoroutine(UpdateSum());

        StartCoroutine(DisplaySong());
    }

    System.Collections.IEnumerator UpdateSum()
    {
        yield return new WaitForSeconds(1f);

        while (currentNumber <= 10)
        {
            sum += currentNumber;
            sumText.text = "Partial Sum: " + sum;
            currentNumber++;
            yield return new WaitForSeconds(1f);
        }
    }

    public TextMeshProUGUI textDisplay;
    public float delayBetweenSentences = 0.5f;
    public string finalPhrase = "The song has ended.";

    private string[] lyrics = {
        "10 green bottles",
        "Hanging on the wall",
        "10 green bottles",
        "Hanging on the wall",
        "And if one green bottle",
        "Should accidentally fall",
        "There’ll be 9 green bottles",
        "Hanging on the wall"
    };

    

    IEnumerator DisplaySong()
    {
        for (int i = 0; i < lyrics.Length; i++)
        {
            textDisplay.text = lyrics[i];
            yield return new WaitForSeconds(delayBetweenSentences);

            // Display only the first sentence of the following strophe
            if (i % 4 == 3 && i != lyrics.Length - 1)
            {
                textDisplay.text = lyrics[i + 1];
                yield return new WaitForSeconds(delayBetweenSentences);
            }
        }

        // Display the final phrase
        textDisplay.text = finalPhrase;
    }











}
