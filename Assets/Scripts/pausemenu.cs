using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour  {
    public Transform PauseMenu;
    public characterControll cc;
    public Bullet bullet;

    void Start()
    {
        cc = GetComponent<characterControll>();
        bullet = GetComponent<Bullet>();

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseMenu.gameObject.activeInHierarchy == false)
            {
                PauseMenu.gameObject.SetActive(true);
                Cursor.visible = true;
                cc.enabled = false;
                bullet.enabled = false;
            } else {
                PauseMenu.gameObject.SetActive(false);
                Cursor.visible = false;
                cc.enabled = true;
                bullet.enabled = true;
            }
        }
		
	}
}
