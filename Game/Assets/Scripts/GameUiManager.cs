using UnityEngine;
using UnityEngine.EventSystems;

public class GameUiManager : MonoBehaviour, IPointerClickHandler
{
    public GameObject[] PopUi;
    void Start()
    {

    }

    void Update()
    {

    }
    public void OpenMap()
    {
        PopUi[0].SetActive(true);
    }
    public void OffMap()
    {
        PopUi[0].SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        OpenMap();
    }
}
