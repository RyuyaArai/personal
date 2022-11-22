using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    float inputHorizontal;
    float inputVertical;
    float moveSpeed = 10f;
    float jumpPower = 500f;
    bool isJump;
    bool isWall;

    void Start(){
    	rb = GetComponent<Rigidbody>();
        isJump = true;
    }

    void Update() {
    inputHorizontal = Input.GetAxisRaw("Horizontal");
    inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;
 
    	// 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero) {
        transform.rotation = Quaternion.LookRotation(moveForward);
        }
        if(isJump==false){
            if (Input.GetKeyDown(KeyCode.Space)) {
                Debug.Log("space");
                rb.AddForce(Vector3.up * jumpPower);
                isJump=true;
    	    }
        }
        if(isWall == true){
            if(inputHorizontal > 0) {
                rb.velocity += new Vector3(0.0f,1.0f,0.0f);
            }
        }
    }


    private void OnCollisionEnter(Collision other){
        if(isJump == true) {
            if (other.gameObject.tag == "Ground") {
	        	isJump = false;
    	    }
            if(other.gameObject.tag == "Wall") {
                isWall = true;
            }
            if(other.gameObject.tag != "Wall"){
                isWall = false;
            }
        }
    }


    private void OnTriggerEnter(Collider other) {
        if(isJump == true) {
            if(other.gameObject.tag == "WallTop") {
                isJump = false;
            }   
        }
    }
}
