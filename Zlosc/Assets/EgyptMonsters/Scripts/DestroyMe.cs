using UnityEngine;
using System.Collections;

public class DestroyMe : MonoBehaviour{
	private float timer;
    public float deathtimer = 1;
    public GameObject OnDestroyFuncTarget;
    public string OnDestroyFuncMessage;

    // Use this for initialization
    private void Start () {
	
	}
	
	// Update is called once per frame
	private void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= deathtimer)
        {
            if (OnDestroyFuncTarget != null)
                OnDestroyFuncTarget.SendMessage(OnDestroyFuncMessage);
            Destroy(gameObject);
        }
	
	}
}
