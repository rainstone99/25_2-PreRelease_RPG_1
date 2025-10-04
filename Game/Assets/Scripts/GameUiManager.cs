using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameUiManager : MonoBehaviour
{
    public GameObject[] popUi; //0: 지도 1: 인벤토리&정보창 2: 미정 3: 설정
    public GameObject[] mapIcon; //0: 전투, 1: 전투, 2: 휴식, 3: 전투, 4: 상점, 5: 전투, 6: 다음 층
    public GameObject[] arrow; // 화살표 7개
    public TextMeshProUGUI[] uiText;

    void Start()
    {
        ArrowActive();
    }
    void Update()
    {
        Ui();
    }

    // 팝업 Ui
    public void OnUi(int Ui) //버튼 인스펙터에서 인자 받고
    {
        for (int i = 0; i < popUi.Length; i++) //배열 만큼 반복하고
        {
            popUi[i].SetActive(i == Ui); // 인자랑 i 랑 똑같으면 true 반환 0번일때 true면 0번 켜짐
        }
    }
    public void OffUi(int Ui) //버튼 인스펙터에서 인자 받고
    {
        popUi[Ui].SetActive(false); // 그냥 꺼버림
    }


    // 화살표 활성화 (현재 스테이지 표시)
    public void StageMove(GameObject arrow)
    {
        switch (arrow.activeSelf)
        {
            case true:
                if (arrow.name == "LocationArrow(1)" || arrow.name == "LocationArrow(2)" || arrow.name == "LocationArrow(4)" || arrow.name == "LocationArrow(6)")
                {
                    SceneManager.LoadScene("BattleScene");
                    GameManager.Instance.CurrentChapter += 1;
                }
                else if (arrow.name == "LocationArrow(3)")
                {
                    SceneManager.LoadScene("HealScene");
                    GameManager.Instance.CurrentChapter += 1;
                }
                else if (arrow.name == "LocationArrow(5)")
                {
                    SceneManager.LoadScene("StoreScene");
                    GameManager.Instance.CurrentChapter += 1;
                }
                else if (arrow.name == "LocationArrow(7)")
                {
                    SceneManager.LoadScene("LobbyScene");
                    GameManager.Instance.CurrentFloor += 1;
                    GameManager.Instance.CurrentChapter = 1;
                }
                break;
            case false:
                break;
        }
    }
    public void ArrowActive()
    {
        for (int i = 0; i < arrow.Length; i++)
        {
            arrow[i].SetActive(i == GameManager.Instance.CurrentChapter - 1);
        }
    }

    // 씬 전환
    public void NextBattle()
    {
        SceneManager.LoadScene("InGameScene");
    }
    public void NextHeal()
    {
        SceneManager.LoadScene("HealScene");
    }
    public void NextStore()
    {
        SceneManager.LoadScene("StoreScene");
    }
    public void NextFloor()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    // 텍스트
    public void Ui()
    {
        uiText[0].text = GameManager.Instance.CurrentFloor + "층";
    }
    
}
