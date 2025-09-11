using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public enum EnemyStateMachine {idle, patrol, chase}
    //public EnemyStateMachine stateMachine;
    public Transform targetCheck;

    public int patrolIndex = 0;
    public Transform[] patrolPoints;

    public float movementSpeed;
    public float delay;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("Idle");
    }

  
    public IEnumerator Idle()
    {
        //Debug.Log("Distance: " + Vector2.Distance(transform.position, patrolPoints[patrolIndex].position));
        anim.SetBool("Idle", true);
        yield return new WaitForSeconds(delay);
        yield return StartCoroutine("Patrol");
    }

    public IEnumerator Patrol()
    {
        anim.SetBool("Idle", false);
        if (transform.position.x > patrolPoints[patrolIndex].position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        while (Vector2.Distance(transform.position, patrolPoints[patrolIndex].position) > 0.1f)
        {
            yield return new WaitForSecondsRealtime(.01f);
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[patrolIndex].position,
                movementSpeed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, patrolPoints[patrolIndex].position) < 0.1f)
        {
            
            if (patrolIndex >= patrolPoints.Length - 1)
            {
                patrolIndex = 0;
            }
            else
            {
                patrolIndex++;
            }
            
            yield return StartCoroutine("Idle");
        }
        
        /*
        else
        {
            yield return StartCoroutine("Patrol");
        }
        */
        
    }

    
}
