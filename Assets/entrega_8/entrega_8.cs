using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR;

public class entrega_8 : MonoBehaviour
{
    public TextMeshProUGUI sumText;
    public TextMeshProUGUI songText;
    public TextMeshProUGUI wordText;
    private int sum;
    private int currentNumber;
    private string frase = "I like videogames";

    void Start()
    {
        sum = 0;
        currentNumber = 1;
        StartCoroutine(UpdateSum());

        

        StartCoroutine(ejercicio2());

        


        StartCoroutine(ejercicio5());
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

    private IEnumerator ejercicio2()
    {
        for (int i = 10; i > 0; i--)
        {
           

         
                yield return new WaitForSeconds(0.5f);
                songText.text = i + " green bottles\n ";
                yield return new WaitForSeconds(0.5f);
                songText.text += "Hanging on the wall\n";
                yield return new WaitForSeconds(0.5f);
                songText.text += i + " green bottles\n ";
                yield return new WaitForSeconds(0.5f);
                songText.text += "Hanging on the wall\n";

                yield return new WaitForSeconds(0.5f);
                songText.text += "And if one green bottle\n";
                yield return new WaitForSeconds(0.5f);
                songText.text += "Should accidentally fall\n";
                yield return new WaitForSeconds(0.5f);
                songText.text += "There’ll be " + (i - 1) + " green bottles\n";
                yield return new WaitForSeconds(0.5f);
                songText.text += "Hanging on the wall\n";



        }

        yield return new WaitForSeconds(0.5f);
        songText.text = "FIN no quedan más . . .\n";

    }

    private IEnumerator ejercicio5()
    {
        wordText.text = "";
        for (int i = 0; i < frase.Length; i++)
        {
            
            wordText.text += frase[i];
            yield return new WaitForSeconds(0.2f);
        }
    }

    }
