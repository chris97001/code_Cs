using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimationController : MonoBehaviour
{
    public MonsterController monsterController;
    Animator animator;
    int isCaughtHash;
    private void Start()
    {
        animator = GetComponent<Animator>();
        isCaughtHash = Animator.StringToHash("isCaught");
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetBool(isCaughtHash, monsterController.isCaught);
    }
}
