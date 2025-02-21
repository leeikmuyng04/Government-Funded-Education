using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    [SerializeField] string title;
    [SerializeField] string description;

    [SerializeField] Text titleText;
    [SerializeField] Text descriptionText;

    private void Awake()
    {
        titleText = transform.GetChild(0).GetComponent<Text>();
        descriptionText = transform.GetChild(1).GetComponent<Text>();
    }

    private void Start()
    {
        titleText.text = title;
        descriptionText.text = description;
    }
}
