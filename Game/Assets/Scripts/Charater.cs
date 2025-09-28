using UnityEngine;

public class Charater : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = new Player(PlayerPrefs.GetString("PlayerName"));
        Debug.Log(player._name);
        Debug.Log(player._hp);
    }
    void Update()
    {
        
    }
}
class Player // 캡술화 테스트
{
    private string name; //따로 선언하고
    private int hp;
    public string _name //프로퍼티를 거쳐서 가져오거나 수정
    {
        get { return name; }
        private set { name = value; }
    }
    public int _damage { get; private set; }
    public int _defence { get; private set; }
    public int _hp
    {
        get { return hp; }
        private set { hp = value; }
    }
    public float _attackTime { get; private set; }
    public float _dodge { get; private set; }
    public Player(string inputname)
    {
        _name = inputname;
        _hp = 1;
    }
}