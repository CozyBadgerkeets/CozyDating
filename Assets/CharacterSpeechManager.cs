using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System.Net;
using Unity.VisualScripting;


public class CharacterSpeechManager : MonoBehaviour
{

    // instead or previous plan of creatinng different arrays
    // make this a prefab that can be tweeked in game
    // and is unique to each character


    // the script writer should still be
    // the same as you want an easy way to create scripts
    // characters


    // UI elements you need to set in Inspector
    public string[] characterLines;
    public TextMeshProUGUI textBox;
    public GameObject panel;

    // text appearance speed
    public float textSpeed;
    // length of each line
    public int index;


    // Start is called before the first frame update
    void Start()
    {
        textBox.text = string.Empty;
        startConverstation();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // on click if coroutine is done moves on to next line
            if (textBox.text == characterLines[index])
            {
                nextLine();
            }
            else
            {
                // on click skips 1 by 1 feature and just displays text
                StopAllCoroutines();
                textBox.text = characterLines[index];
            }
        }
    }

    void startConverstation()
    {
        // index needs to be 0 to start with the array
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        // type each character 1 by 1
        foreach(char c in characterLines[index].ToCharArray())
        {
            // reminder that bellow is a C and not a circle
            textBox.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void nextLine()
    {
        // make break if nextline string = break or some other keyword
        // that way you can create a break where the player can answer and the character responds

        // TRUE if index is less than the array length
        // meaning with all the lines in the array
        if (index < characterLines.Length - 1)
        {
            // if index is less than the array
            // increase index by 1 to move on to the
            // next line
            index ++;
            // Reset the text box to empty 
            textBox.text = string.Empty;
            // and start the coroutine again
            // but with the new line
            StartCoroutine(TypeLine());
        }
        else
        {
            // otherwise deactivates the box
            // change the move on to selection or
            // next scene
            textBox.gameObject.SetActive(false);
            // if panel is available in the inspector
            // deactivate panel when speech ends
            if (panel)
            {
                panel.gameObject.SetActive(false);
            }
        }
    }
}
