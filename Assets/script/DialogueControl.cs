using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueControl : MonoBehaviour
{
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorname;
    public float typespeed;
    private string[] sentences;
    private int index;

    
    public void Speech(Sprite p, string[] txt, string actn)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorname.text = actn;
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typespeed);
        }

    }

    public void NextSentence()
    {
        if (speechText.text == sentences[index])
        {
            if (index < sentences.Length - 1)
            {
                index++;
                speechText.text = "";
                StartCoroutine(TypeSentence());

            }
            else
            {
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive (false);
            }
        }
    }



}


