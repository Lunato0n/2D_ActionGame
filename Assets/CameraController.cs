using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	//プレイヤーオブジェクト
	private GameObject _Player;

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーオブジェクトを取得
		_Player = GameObject.Find( "HeroKnight");
    }

    // Update is called once per frame
    void Update()
    {
		//存在する？
		if( _Player != null)
		{
			Vector3 position = this.transform.position;
			//1秒かけて追従
			position.x += (_Player.transform.position.x - position.x) * Time.deltaTime;
			//position.y += (_Player.transform.position.y - position.y) * Time.deltaTime;
			this.transform.position = position;
		}
    }
}
