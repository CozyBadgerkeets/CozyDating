    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class BastetSpeechManager : MonoBehaviour
{
    // Different systems for different characters
    // all with have their own array in different scenes
    // so that there isnt too much clutter

    // create a loop that takes lines from a text document and puts them into a specfic array depending on who said it

    public string[] BastetSpeechSystem;
    public TextMeshProUGUI BastetBox;

    public float textSpeed;
    public int index;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        // Sets text box empty to not conflict with anything
        BastetBox.text = string.Empty;
        // start Convo automatically for testing
        StartConvo();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            // on click if coroutine is done moves on to next line
            if (BastetBox.text == BastetSpeechSystem[index])
            {
                Nextline();
            }
            else
            {
                // on click skips 1 by 1 feature and just displays text
                StopAllCoroutines();
                BastetBox.text = BastetSpeechSystem[index];
            }
        }
    }
    void StartConvo()
    {
        // Index needs to be 0 to start with the array
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        // type each character 1 by 1
        foreach(char c in BastetSpeechSystem[index].ToCharArray())
        {
            // reminded that bellow is a C and not a circle
            BastetBox.text += c;
            
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void Nextline()
    {
        // True if index is less than array length
        // meaning with all the lines in the array 
        if(index < BastetSpeechSystem.Length - 1)
        {
            
            // if index is less than array
            // Increase index by 1 to move on to the next line
            index++;
            // Reset the text box to emptu
            BastetBox.text = string.Empty;
            // and start the coroutine with the new line
            StartCoroutine(TypeLine());
        }
        else
        {
            // otherwise deactivates the box
            // change to move on to selection or next scene
            BastetBox.gameObject.SetActive(false);
            if(panel)
            {
                panel.gameObject.SetActive(false);
            }
        }
    }
}
