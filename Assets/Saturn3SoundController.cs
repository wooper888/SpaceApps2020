using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saturn3SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    //戻るボタンで選択画面に遷移する
    public void SelectButtonDown()
    {
        SceneManager.LoadScene("SelectScene");
    }

    // Update is called once per frame
    void Update()
    {


        //PCでの処理
        //クリックで音を鳴らす、止める
        if (Input.GetMouseButtonDown(0))
        {

            GetComponent<AudioSource>().Play();
            Debug.Log("Touch");

        }

        if (Input.GetMouseButtonUp(0))
        {

            GetComponent<AudioSource>().Stop();

        }


        if (Input.touchCount > 0)
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                GetComponent<AudioSource>().Play();
                Debug.Log("押した瞬間");
            }

            if (touch.phase == TouchPhase.Ended)
            {
                GetComponent<AudioSource>().Stop();
                Debug.Log("離した瞬間");
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("押しっぱなし");
            }

        }
    }
}
