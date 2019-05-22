using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    [SerializeField]
    private CharacterController zombieController;
    [SerializeField]
    private CharacterController playerController;

    //private Vector3 enemy;

    // Start is called before the first frame update
    void Start()
    {
        
        //enemy = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetZombiePosition = playerController.transform.position;
        zombieController.transform.position = Vector3.Lerp(zombieController.transform.position, targetZombiePosition, 1.2f * Time.deltaTime);

        // Vector3 moveDirection = new Vector3(playerController.transform.position.x, playerController.transform.position.y, playerController.transform.position.z);
        // zombieController.SimpleMove(moveDirection * .08f);
                
        //Vector3.MoveTowards(new Vector3(10000,0,10000), enemy, 100);
        //Vector3.MoveTowards
        //enemy.position = Vector2.MoveTowards(enemy.position, wayPoints[target].position, navigationTime);
    }
    void FixedUpdate(){
        //Vector3 moveDirection = new Vector3(playerController.transform.position.x, playerController.transform.position.y, playerController.transform.position.z);
        //zombieController.SimpleMove(moveDirection * .08f);
    }
}
