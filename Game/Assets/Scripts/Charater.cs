using UnityEngine;
using UnityEngine.SceneManagement;

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
    void PlayerAttack()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(-5f, -2f), 10f * Time.deltaTime); // 공격 갔다가

        if (transform.position.x < -4.5f) // 거의 끝까지 가면 돌아오기
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(5f, -2f), 10f * Time.deltaTime);
        }
    }
    void PlayerHit(Collider2D collider2D) // 부딪히면 작동
    {
        if (transform.position.x >= 4) // 적이 거의 제자리에 있을때는 공격성공
        {
            Monster.monster.Hp -= -1;
        }
        else if (transform.position.x < 4) // 아니면 공격 실패
        {
            // 중간에서 만나면 이동중단하고 제자리로 돌아가는 코드
            Debug.Log("튕겨져 나감"); 
        }
    }
    void PlayerDamaged(Collider2D collider2D)
    {
        player.Hp -= 1;
        if (player.Hp == 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnDestroy()
    {
        SceneManager.LoadScene("GamaOver");
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
        set { _hp = value; }
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