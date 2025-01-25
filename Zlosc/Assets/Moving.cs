using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Moving : MonoBehaviour
{
    private float timer;
    public float speed;
    public Transform target;
    public GameObject OnDestroyFuncTarget;
    public string OnDestroyFuncMessage;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject targetObject = GameObject.Find("pole");
        target = targetObject.transform;
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed);
        timer += Time.deltaTime;

        if (!(timer >= 15)) return;
        if (OnDestroyFuncTarget)
            OnDestroyFuncTarget.SendMessage(OnDestroyFuncMessage);
        Destroy(gameObject);
    }
}
