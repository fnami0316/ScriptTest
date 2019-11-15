using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
//余力がある方、さらに理解を深めたい方は発展課題もチャレンジしましょう！
//Lesson4で作成したプロジェクトScriptTestに追記しましょう。

//Bossクラスについて下記の条件を満たしてください
//Lesson4で作成したBossクラスをもとに作成してください

//int型の変数mpを宣言し、53で初期化してください
//mpを消費して魔法攻撃をするMagic関数を作ってください
//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
//Start関数で下記の条件を満たしてください

//Magic関数を呼び出して、魔法を使ってください
//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
public class Boss {
    // 体力
    private int hp = 100;
    // 攻撃力
    private int power = 25;
    // 魔力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic() {
        // MP余裕
        if((mp - 5) >= 0) {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        // MP不足
        else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour {
    /*
        課題：配列を宣言して出力しましょう
        配列を宣言して出力しましょう。
        Lesson4で作成したプロジェクトScriptTestに追記しましょう。
        下記の条件を満たしてください
        要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        for文を使い、配列の各要素の値を順番に表示してください
        for文を使い、配列の各要素の値を逆順に表示してください
    */
    void Task() {
        // 初期化
        int[] array = { 10, 11, 12, 13, 14 };

        // 順番に表示
        for(int i = 0; i < array.Length; i++) Debug.Log(array[i]);

        // 逆順に表示
        for(int i = array.Length - 1; i >= 0; i--) Debug.Log(array[i]);
    }

    void Start() {
        // 課題を実行
        Debug.Log("＝＝課題＝＝");
        Task();
        Debug.Log("＝＝課題ここまで＝＝");

        // 発展課題を実行
        Debug.Log("＝＝発展課題＝＝");
        Boss boss = new Boss();
        for(int i = 0; i < 11; i++) {
            Debug.Log("魔法を" + (i + 1) + "回使用");
            boss.Magic();
        }
        Debug.Log("＝＝発展課題ここまで＝＝");
    }


    // Update is called once per frame
    void Update() {

    }
}
