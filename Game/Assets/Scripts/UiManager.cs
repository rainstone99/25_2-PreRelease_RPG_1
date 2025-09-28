using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public TMP_InputField playerNameInput;
    public GameObject[] popUpUi; // 0: 닉네임 입력창 1: 닉네임 경고창 2: 에러창
    private string playerName = null;
    void Awake()
    {

    }
    void Start()
    {

    }

    void Update()
    {

    }
    public void PlayerName()
    {
        playerName = playerNameInput.text;
        if (playerName.Length > 0)
        {
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
        else if (playerName.Length == 0)
        {
            Alert();
        }
        else
        {
            Error();
        }
    }
    public void StartButton()
    {
        popUpUi[0].SetActive(true);
    }
    public void GameStart()
    {
        PlayerName();
        Debug.Log(playerName.Length);
    }
    public void Alert()
    {
        popUpUi[1].SetActive(true);
        Invoke("AlertOff", 1.5f);
    }
    public void AlertOff()
    {
        popUpUi[1].SetActive(false);
    }
    public void Error()
    {
        popUpUi[2].SetActive(true);
        Invoke("Exit", 10f);
    }
    public void Exit()
    {
        Application.Quit();
    }
}