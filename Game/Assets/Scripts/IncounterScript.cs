using UnityEngine;

public class IncounterScript : MonoBehaviour
{
    void Awake()
    {

    }
    void Start()
    {
        
    }

    void Update()
    {

    }

}
//폐기    
// public GameObject[] prefab; //0: 몬스터, 1: 회복, 2: 상인 3:다음 층
// private Vector2[] markPoint = new Vector2[4];
// public GameObject map;
// private RectTransform mapPoint;
// private RectTransform iconPoint;
// private float xPoint = -600f;
//     void MapMarkerAdd(GameObject prefab, Vector2 point)
    //     {
    //         mapPoint = map.GetComponent<RectTransform>();
    //         iconPoint = prefab.GetComponent<RectTransform>();
    //         iconPoint.anchoredPosition = Vector2.zero;
    //         GameObject mapMark = Instantiate(prefab, point, Quaternion.identity, mapPoint);
    //     }
    //     void MapMarkerSpawn() //for문으로 x좌표값 +400씩 4번 반복해서 4개의 인카운터 랜덤생성하게
    //     {
    //         // markPoint[0] = new Vector2(-600f, 0f);
    //         // markPoint[1] = new Vector2(-200f, 0f);
    //         // markPoint[2] = new Vector2(200f, 0f);
    //         // markPoint[3] = new Vector2(600f, 0f);
    //         for (int i = 0; i < 4; i++, xPoint += 400) // 이건 좌표 생성
    //         {
    //             int randomIncounter = Random.Range(0, 4);
    //             MapIconPoint point = new MapIconPoint(xPoint);
    //             markPoint[i] = point.IconPoint;
    //             switch (randomIncounter)
    //             {
    //                 case 0: //몬스터
    //                     MapMarkerAdd(prefab[0], markPoint[i]);
    //                     break;
    //                 case 1: //회복
    //                     MapMarkerAdd(prefab[1], markPoint[i]);
    //                     break;
    //                 case 2: //상인
    //                     MapMarkerAdd(prefab[2], markPoint[i]);
    //                     break;
    //                 case 3: //다음 층
    //                     MapMarkerAdd(prefab[3], markPoint[i]);
    //                     break;
    //                 default: //예외
    //                     Debug.Log("error");
    //                     break;
    //             }
    //         }
    //     }
    // }
    // class MapIconPoint
    // {
    //     public Vector2 IconPoint { get; private set; }
    //     public MapIconPoint(float xPoint)
    //     {
    //         IconPoint = new Vector2(xPoint, 0f);
    //     }