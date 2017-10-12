using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    //timeRemaining에 적절한 숫자(초단위)를 넣어주세요.
    public int timeRemaining;
    public Text timer;
    Button m_button; //타이머 버튼
    public static bool check = false; //타이머 동작을 체크해주는 변수
    


    void Start () {

        //현재 씬 안에서 해당하는 컴포넌트들을 불러옴
        timer = GameObject.Find("Timer Text").GetComponent<Text>();
        m_button = GameObject.Find("TimeButton").GetComponent<Button>();
        //StartCoroutine(start());
    }
	
	// Update is called once per frame
	void Update ()
    {
        //프레임 단위로 계속 체크
        //Debug.Log("업데이트 지켜보고있음 / check : "+check);
        if (check)
        {
            check = false; //체크를 해제
            Debug.Log("업데이트");
            StartCoroutine(start()); //코루틴 실행
        }
    }

    public IEnumerator start()
    {

        Debug.Log("IEnumerator start");
        timeRemaining = 900;
        int min = 0;
        int sec = 0;
        while (timeRemaining > 0) //전체 시간이 0보다 클 경우 계속 실행
        {
            //1초 기다림
            yield return new WaitForSeconds(1);
            min = timeRemaining / 60;
            sec = timeRemaining % 60;
            Debug.Log("남은 시간" + timeRemaining + "/" + min + "분" + sec + "초");

            /*
             * 
             * Format함수 {N:DX}
             *N : 인자의 순서
             *X : 자리 수
             * 
             */
            timer.text = string.Format("{0:D2} : {1:D2}", min, sec);
            timeRemaining--; //전체 시간에서 1초를 제거
            
        }
        yield return new WaitForSeconds(1);
        timer.text = "Finished";
        SoundManager.instance.PlaySound();

        //이쯤에서 사운드 넣어주는 함수 넣으면 될거같음. 소스 구하면 넣을 것.


    }

    public void onClick_TimerButton()
    {
        //버튼 숨김
        m_button.gameObject.SetActive(false);
        timer.text = "Start!";
        //타이머 활성 체크
        check = true;
        Debug.Log("Check True");
        
        
    }

}
