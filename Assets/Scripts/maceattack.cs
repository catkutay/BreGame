// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class maceattack : MonoBehaviour
// {
//     public enum AttackDirection{
//         left, right
//     }

//     public AttackDirection attackDirection;

//     Vector2 rightAttackOffset;

//     Collider2D maceCollider;

//     private void Start(){
//         maceCollider = GetComponent<Collider2D>();
//         rightAttackOffset = transform.position;

//     }

//     public void Attack(){
//         switch(attackDirection){
//             case AttackDirection.left:
//                 AttackLeft();
//                 break;
//             case AttackDirection.right:
//                 AttackRight();
//                 break;
//         }
//     }

//     private void AttackRight(){
//         maceCollider.enabled = true;
//         transform.position = rightAttackOffset;

//     }

//     private void AttackLeft(){
//         maceCollider.enabled = true;
//         transform.position = new Vector3(rightAttackOffset.x*-1, rightAttackOffset.y);

//     }

//     private void StopAttack(){
//         maceCollider.enabled = false;
//     }

// }
