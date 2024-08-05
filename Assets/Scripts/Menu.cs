using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private UIDocument document;
    private Button BotaoJogar;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        BotaoJogar = document.rootVisualElement.Q<Button>("btn_jogar");
        BotaoJogar.RegisterCallback<ClickEvent>(OnPlayGame);
    }

    void OnPlayGame(ClickEvent evt)
    {
        SceneManager.LoadScene("Main");
    }
}
