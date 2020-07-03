using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineTutorial : MonoBehaviour
{
    public Transform target;
    public Text messageText;
    string message = "This is a tutorial on Unity and we are trying subtitles, and how we make them.";
    string[] words;

    void Start()
    {
        words = message.Split(' ');
        //StartCoroutine(MoveToTarget(target, 2));
    }
    IEnumerator current;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (current != null)
            {
                StopCoroutine(current);
            }
            current = MoveToTarget(Random.insideUnitCircle * 5, 2);
            StartCoroutine(current);
        }
    }


    IEnumerator PrintDialog()
    {
        foreach (var word in words)
        {
            //Debug.Log(word);

            messageText.text += word + " ";
            yield return new WaitForSeconds(0.1f);
        } 
    }

    IEnumerator MoveToTarget(Vector3 target, float moveSpeed)
    {
        while(transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * moveSpeed);
            yield return null;
        }
        Debug.Log("Done");
    }

    
}
 