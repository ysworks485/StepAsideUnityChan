using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    // Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Use this for initialization   
    void Start()
    {
        // Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
    ////////////////////////////////////////////////////////////////////////////////////
    // Lesson6 課題作成再提出（画面外に出たオブジェクトを削除する）
    ////////////////////////////////////////////////////////////////////////////////////

        // Unityちゃんから10m後ろのz座標（カメラの位置）
        float bottomScreen = unitychan.transform.position.z - 10;

        if (this.gameObject.transform.position.z < bottomScreen) {
            Destroy(this.gameObject);

        }

    }
    ////////////////////////////////////////////////////////////////////////////////////
    // Lesson6（画面外に出たオブジェクトを削除する）課題作成１回目→結果NG
    //　大貫メンターのコメント（抜粋）
    //  ↓このやり方は弱点があります。たとえば Unityのシーンビューでコース全体を
    //  　見下ろすようにして、ゲームをプレイしてみてください。通り過ぎたアイテムが
    //  　消去されないのが確認できると思います。「OnBecameInvisible」関数はシーンビュー
    //  　に見えているものもカメラに写っているものとして処理されます。
    ////////////////////////////////////////////////////////////////////////////////////
    //void OnBecameInvisible()
    //{
    //    Destroy(this.gameObject);
    //}

}

