using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    [SerializeField]
    TextMeshProUGUI timeText;
    [SerializeField]
    float duration, currentTime;
    [SerializeField]
    GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        currentTime = duration;
        timeText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());
    }

    IEnumerator TimeIEn()
    {
        while(currentTime >= 0)
        {
            timeText.text = "Time: " + currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        OpenPanel();
        Player.SetActive(false);
    }


    void OpenPanel()
    {
        timeText.text = "Time: 0";
        panel.SetActive(true);
    }

}
