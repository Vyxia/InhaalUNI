using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


    public Camera camera;

	// Use this for initialization
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(0.01f, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-0.01f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.01f);
        }

        camera.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y,this.transform.position.z-2);

	}
}
