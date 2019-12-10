using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Info : MonoBehaviour
{
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "football")
        {
            txt.text="학생회관 1층 학생지원과에서 예약하여 이용\n38M X 20M(가로 X 세로)";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Ginyeom-Gwan")
        {
            txt.text="1층 - 인터넷 카페\n2층 - 총대실홀, 교수 휴게실, 신학대학, 예술대학 교수연구실\n3층 - 극장, 평생교육원 사무실, 평생교육원 교수 휴게실\n4층 - 에스테틱실, 헤어 디자인실, 국제회의실, 메이크업실, 연극영화학부, 연기실습실, 영양기념실,교육매체제작실\n5층 - 대강당, 강사접견실, 교목실, 성가대준비실";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Yeongam_Gwan")
        {
            txt.text="지하 – 피아노연습실\n1층 – 어학 실습실\n3층 – 디지털 피아노실, 세미나실\n4층 – 임용 고시반, 사범대학 교수 연구실\n5층 – 교구 제작실, 인문대학 교수 연구실";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "GLOBAL-LOUNGE")
        {
            txt.text="학생회관 앞\n아메리카노\n카페라떼\n버블티\n아이스티\n쉼터\n그룹회의실";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "SeongGyeol-Gwan")
        {
            txt.text="공대\n산업경영공학과\n컴퓨터공학과\n정보통신공학과\n미디어소프트웨어학과\n도시디자인정보공학과\n컴퓨터\n설계실\n실습실\n공대학생회";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Hagsaenghoe-Gwan")
        {
            txt.text="헬스장\njobcafe\n과실\n동아리실\n방송국\nATM기기\n학생생활상담소\n장애학생지원센터\n사회봉사센터";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Jaelim-Gwan")
        {
            txt.text="대학본부\n입학관리\n대학일자리센터\n학사관리과\n자유열람실\n이사장실\n회의실\n노동조합센터";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Library")
        {
            txt.text="1층 – 자동서고 / 이용자서비스센터 / 일반열람실 / 노트북 열람실 / XR센터 / U라운지\n2층 – (멀티미디어/전자정보실) / 그룹 감상실/ 레드룸 / 자유열람실 / 소극장\n3층 – 그룹 스터디룸 / 제1~2 자료열람실 / 오렌지룸\n4층 – 그룹 세미나룸 / 제3~4 자료열람실 / 옐로우룸\n5층 – (연속간행물 / 참고열람실) / 대학원 열람실 / 연구 열람실\n6층 – 하늘정원 / 카페열람실 / 고서실 / 신수기념실 / 영암기념실 / 소회의실 / 야립국제회의실";
        }
        else if(DefaultTrackableEventHandler.mTrackableBehaviour.TrackableName == "Test")
        {
            txt.text="테스트";
        }
    }
}
