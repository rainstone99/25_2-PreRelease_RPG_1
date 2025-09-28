using UnityEngine;

public class Charater : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = new Player(PlayerPrefs.GetString("PlayerName"));
        Debug.Log("당신의 닉네임" + player.Name);
        Debug.Log("현재 HP" + player.Hp);
    }
    void Update()
    {
        
    }
}
class Player // 캡술화 테스트
{
    private string _name; //필드 따로 선언하고
    public string Name //프로퍼티를 거쳐서 가져오거나 수정, 주의)이름이 같으면 무한재귀
    {
        get { return _name; }
        private set { _name = value; }
    }
    private int _hp;
    public int Hp
    {
        get { return _hp; }
        private set { _hp = value; }
    }
    public int _damage { get; private set; } // 그냥 바로 사용
    public int _defence { get; private set; }
    public float _attackTime { get; private set; }
    public float _dodge { get; private set; }
    public Player(string inputName) // 클래스와 함수 이름이 같으면 생성자
    {
        Name = inputName;
        Hp = 1;
    }
}