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
    ///�@�ł��o�����ʃR�[���o�b�N
    /// </summary>
    /// <param name="success">���ی��� ���ʂ��������s�ȊO�ɂȂ�Ȃ�enum��</param>
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
