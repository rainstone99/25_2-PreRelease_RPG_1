using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject otherManager;
    private static GameManager instance; // 전역에서 사용되는 변수만 저장
    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    public int CurrentFloor { get; set; } = 1;
    public int CurrentChapter { get; set; } = 1;
    public bool AttackTurn { get; set; } = true;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        StartGame();
    }

    void Update()
    {

    }
    public void StartGame()
    {
        if (CurrentChapter == 0)
        {
            CurrentChapter = 1;
        }
        if (CurrentFloor == 0)
        {
            CurrentFloor = 1;
        }
    }
}
