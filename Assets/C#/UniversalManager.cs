using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UniversalManager : MonoBehaviour
{
    public Sprite[] backgrounds;
    public Image background;
    public TMP_Text nameMap;

    // Start is called before the first frame update
    void Start()
    {
        string map = SelectMapPage.selectMap;
        Debug.Log(map);
        nameMap.text = "Welcome to " + map;
        int number = 0;
        
        if (map.Equals("Abandoned Temple")) {
            number = 0;
        }
        else if (map.Equals("Amagedon Town"))
        {
            number = 1;
        }
        background.sprite = backgrounds[number];

    }

    
}
