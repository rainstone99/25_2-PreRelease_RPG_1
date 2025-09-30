using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameUiManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] popUi; //0: 지도
    public GameObject[] mapIcon; //0: 전투, 1: 전투, 2: 휴식, 3: 전투, 4: 상점, 5: 전투, 6: 다음 층
    public TextMeshProUGUI[] uiText;
    public int CurrentFloor { get; private set; }
    public int ClearFloor { get; private set; }
    void Start()
    {
        CurrentFloor = 1;
    }

    void Update()
    {
        Ui();
    }
    public void OpenMap()
    {
        popUi[0].SetActive(true);
    }
    public void OffMap()
    {
        popUi[0].SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        OpenMap();
    }
    public void IconAdd()
    {
        // switch ()
        // case
    }
    public void Ui()
    {
        uiText[0].text = CurrentFloor + "층";
    }
    public void Clear()
    {
        CurrentFloor += ClearFloor;
    }
}
