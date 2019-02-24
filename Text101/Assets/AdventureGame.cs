using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    string storyText = ("There we are. This present moment is perfect simply due to the fact you're experiencing it. Just let go - and fall like a little waterfall. Nothing's gonna make your husband or wife madder than coming home and having a snow-covered dinner. It's beautiful - and we haven't even done anything to it yet. We're trying to teach you a technique here and how to use it.");
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = storyText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
