using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField input;
    public static string playerName;
    public TextMeshPro highScoreWelcome;

    void Start()
    {
        input.onEndEdit.AddListener(delegate { inputBetValue(input); });
    }

    public void inputBetValue(TMP_InputField input)
    {
        playerName = input.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}
