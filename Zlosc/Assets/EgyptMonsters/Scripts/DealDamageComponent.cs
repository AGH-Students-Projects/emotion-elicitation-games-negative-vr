﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamageComponent : MonoBehaviour {

    public GameObject hitFX;

    private void DealDamage() {
        transform.parent.GetComponent<DemoController>().DealDamage(this);
    }
	

}
