using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class pp2 : MonoBehaviour {     //脚本挂到相机上
public Transform target;   //  设置为 需要跟随的物体
    public float distanceUp = 10f;//相机与目标的竖直高度参数
    public float distanceAway = 10f;//相机与目标的水平距离参数
    public float smooth = 2f;//位置平滑移动插值参数值
    public float camDepthSmooth = 20f;
 
    void Update()
    {
        // 鼠标轴控制相机的远近
        if ((Input.mouseScrollDelta.y < 0 && Camera.main.fieldOfView >= 3) || Input.mouseScrollDelta.y > 0 && Camera.main.fieldOfView <= 80)
        {
            Camera.main.fieldOfView += Input.mouseScrollDelta.y * camDepthSmooth * Time.deltaTime;
        }
    }
 
    void LateUpdate()
    {
        //计算出相机的位置
        Vector3 disPos = target.position + Vector3.up * distanceUp - target.forward * distanceAway;
 
        transform.position = Vector3.Lerp(transform.position, disPos, Time.deltaTime * smooth);
        //相机的角度
        transform.LookAt(target.position);
    }
}
