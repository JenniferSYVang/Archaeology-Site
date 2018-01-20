using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{

    public Transform trackedObject;
    public Transform miniMapObject;
    public Transform baseOrig;
    public Transform boundOrigX;
    public Transform boundOrigZ;
    public Transform boundMiniX;
    public Transform boundMiniZ;
    public float lengthXOriginal;
    public float lengthYOriginal;
    public float lengthZOriginal;
    public float lengthXMiniMap;
    public float lengthYMiniMap;
    public float lengthZMiniMap;

    private float ratioX;
    private float ratioY;
    private float ratioZ;

    public GameObject dynamicObject;

    void Start()
    {
        lengthXOriginal = Vector3.Distance(baseOrig.position, boundOrigX.position);
        lengthZOriginal = Vector3.Distance(baseOrig.position, boundOrigZ.position);
        lengthXMiniMap = Vector3.Distance(transform.position, boundMiniX.position);
        lengthZMiniMap = Vector3.Distance(transform.position, boundMiniZ.position);
        ratioX = (lengthXMiniMap / lengthXOriginal);
        ratioY = (lengthYMiniMap / lengthYOriginal);
        ratioZ = (lengthZMiniMap / lengthZOriginal);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionGod = trackedObject.position - baseOrig.position;
        Vector3 newPositionGod = new Vector3();
        newPositionGod.x = ratioX * positionGod.x;
        newPositionGod.y = ratioY * positionGod.y;
        newPositionGod.z = ratioZ * positionGod.z;
        miniMapObject.localPosition = newPositionGod;
    }

 /*   public void AddDynamicObject(Transform transform)
    {
        GameObject go = Instantiate(dynamicObject, this.transform);
        MiniMapEnemy miniMapEnemy = go.GetComponent<MiniMapEnemy>();
        miniMapEnemy.Initialize(baseOrig, transform, ratioX, ratioY, ratioZ);

    }
    */
}