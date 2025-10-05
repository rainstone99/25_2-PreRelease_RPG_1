using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    public static MonsterInfo monster = new MonsterInfo("기사", 5, 1); // 코드가 꼬여서 임시로 static 붙임, -> 배틀페이즈, 상점, 로비Ui, 기본Ui, 매니저 다 따로따로 나눠야 함함
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(MonsterAttack());

    }
    void OnDestroy()
    {
        Destroy(this.gameObject);
        GameManager.Instance.CurrentChapter += 1;
        SceneManager.LoadScene("LobbyScene");
    }
    void Attack()
    {
        if (GameManager.Instance.AttackTurn)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(-5f, -2f), 10f * Time.deltaTime); // 떄리고
            if (this.transform.position.x <= -4.5f)
            {
                GameManager.Instance.AttackTurn = false;
            }
        }
        else if (!GameManager.Instance.AttackTurn)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(5f, -2f), 10f * Time.deltaTime); // 다시 제자리로 돌아오기
            if (this.transform.position.x >= 4.5f)
            {
                GameManager.Instance.AttackTurn = true;
            }
        }
    }
    IEnumerator MonsterAttack() // 현재 의도대로 작동 안됨
    {
        while (true)
        {
            float attackTime = Random.Range(1.5f, 4f); 
            Attack();
            yield return new WaitForSeconds(attackTime); //랜덤한 시간마다
        }
    }
}
public class MonsterInfo
{
    private string _name; 
    public string Name 
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
    public int _damage { get; private set; }
    public int _defence { get; private set; }
    public float _attackTime { get; private set; }
    public float _dodge { get; private set; }
    public MonsterInfo(string inputName, int hp, int damage)
    {
        Name = inputName;
        Hp = hp;
        _damage = damage;
    }
}