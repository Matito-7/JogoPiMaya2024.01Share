using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public Sprite profile;
    public string[] speechText;
    public string actorname;
    public LayerMask PlayerLayer;
    private DialogueControl dc;
    public float radious;
    public bool onradious;


     void Start()
    {
        dc = FindObjectOfType<DialogueControl>();
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dc.Speech(profile, speechText, actorname);
        }
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, PlayerLayer);
        if (hit != null)
        {
            onradious = true;
        }
        else
        {
            onradious = false;
        }
    }
}
