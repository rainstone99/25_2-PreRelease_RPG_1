using System.Collections;
using UnityEngine;

public class Monster : MonoBehaviour
{
    bool attack = true;
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(MonsterAttack(AttackTime()));
    }
    void OnDestroy()
    {
        Clear();
    }
    public void Clear()
    {
        GameManager.Instance.CurrentChapter += 1;
    }
    float AttackTime()
    {
        float attackTime = Random.Range(1.5f, 4f);
        return attackTime;
    }
    void Attack()
    {
        if (attack)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(-5f, -2f), 10f * Time.deltaTime);
            if (this.transform.position.x <= -4.5f)
            {
                attack = false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(5f, -2f), 10f * Time.deltaTime);
            if (this.transform.position.x >= 4.5f)
            {
                attack = true;
            }
        }
    }

    IEnumerator MonsterAttack(float attackTime)
    {
        Attack();
        yield return new WaitForSeconds(5f);
    }
}
