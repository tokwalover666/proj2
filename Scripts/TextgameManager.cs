using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextgameManager : MonoBehaviour
{
    //declare a variable int
    public int hpValue, sanityValue;

    //declare a variable textmeshpro
    public TextMeshProUGUI hpTextValue, sanityTextValue, storyTextValue;

    //declare a variable string
    public string story;

    public GameObject level1_choices;
    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanityValue = 10;
        story = "WHO DO YOU LOVE THE MOST?";

    }

    // Update is called once per frame
    void Update()
    {
        //textmespro variable = value int
        hpTextValue.text = hpValue.ToString();
        sanityTextValue.text = sanityValue.ToString();
        storyTextValue.text = story;
    }

    public void mom() 
    {
        hpValue -= 1;
        story = "MAY DADDY ISSUES KA!";
        level1_choices.SetActive(false);
    }

    public void dad() 
    {
        sanityValue -= 1;
        story = "MAY MOMMY ISSUES KA!";
        level1_choices.SetActive(false);
    }
}
