using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	//�v���C���[�I�u�W�F�N�g
	private GameObject _Player;

    // Start is called before the first frame update
    void Start()
    {
        //�v���C���[�I�u�W�F�N�g���擾
		_Player = GameObject.Find( "HeroKnight");
    }

    // Update is called once per frame
    void Update()
    {
		//���݂���H
		if( _Player != null)
		{
			Vector3 position = this.transform.position;
			//1�b�����ĒǏ]
			position.x += (_Player.transform.position.x - position.x) * Time.deltaTime;
			//position.y += (_Player.transform.position.y - position.y) * Time.deltaTime;
			this.transform.position = position;
		}
    }
}
