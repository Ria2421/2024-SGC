using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<GameObject> m_bulletObjectList;



    // Start is called before the first frame update
    void Start()
    {
        m_bulletObjectList = new List<GameObject>();
        

    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void AddScore( int _addScore )
    {


    }


    /// <summary>
    ///　打ち出し結果コールバック
    /// </summary>
    /// <param name="success">成否結果 結果が成功失敗以外になるならenumに</param>
    public void OnResultShoot( bool _success )
    {

        if ( _success )
        { 
            AddScore(0);
        }
        else
        {
            AddScore(-1);
        }
    }
}
