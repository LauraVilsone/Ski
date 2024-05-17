using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : Obstacle {
    public GameObject snowParticles;

    public override void hitPlayer(GameObject player)
    {
        base.hitPlayer(player);
        Debug.Log("DESTROOOY");
        Destroy(gameObject);
		Instantiate(snowParticles, player.transform.position, Quaternion.identity);
	}
}