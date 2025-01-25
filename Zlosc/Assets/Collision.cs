using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float fallingspeed;
    private Rigidbody eagle;
    private bool Dead;

    private float timer;
    public float deathtimer = 1;
    public GameObject OnDestroyFuncTarget;
    public string OnDestroyFuncMessage;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        eagle = GetComponent<Rigidbody>();
        eagle.useGravity = true;
    }

    private void Update()
    {
        eagle = GetComponent<Rigidbody>();
        if (eagle.useGravity == true)
        {
            transform.Translate(Vector3.forward * fallingspeed);
            Dead = true;
        }
        if (Dead)
        {
            timer += Time.deltaTime;

            if (!(timer >= deathtimer)) return;
            
            if (OnDestroyFuncTarget)
                OnDestroyFuncTarget.SendMessage(OnDestroyFuncMessage);
            Destroy(gameObject);
        }
    }
}
