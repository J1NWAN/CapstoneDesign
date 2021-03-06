# 화재 대피 시뮬레이션 - (교내 캡스톤디자인 경진대회)
## 제작하게 된 계기
화재 대피 시뮬레이션을 현실감 있고 눈으로 직접 경험할 수 있도록 하기 위하여 VR을 이용하여 제작하게 되었습니다<br>
우선 실제 화재 상황처럼 연기를 마시면 고통을 느끼듯 플레이어 캐릭터의 HP가 서서히 감소되게 만들었습니다<br>
이 프로젝트를 완성하고 감독관 및 여러 학생에게 테스트해 본 결과 VR이 현재 보급되지 않은 상태이긴 하지만<br>
VR 공급이 조금 더 수월해지면 동영상 강의나 이론으로 설명하는 화재 대피보다 훨씬 더 효율적이라는 긍정적인 평가를 받았고 참신한 소재라는 평을 받았습니다.

## 제작 인원 <br>
- 최O석: 기획, Unity UX&UI, C# Sub
- 이O호: 자료조사, 디렉토리북, Tester
- 이O현: 자료조사, 디렉토리북, PPT
- 천O진: 자료조사, 영상편집, PPT
- 전진완: Unity UX&UI, C#
<br>

## 사용한 기술 및 자료
### Program
- Oculus Quest VR Software
- Unity 19.4.30f1v
- Visual Stdio(Code)
<br>

필요한 Asset은 UnityAsset Store에서 구매 하였습니다.
<br>

## Scene 구성
### Title Scene
게임시작시 가장 먼저 보이는 Scene이며, Oculus Controller를 이용하여 해당 버튼의 이벤트를 실행할 수 있습니다.
- 구성
  - 게임시작(Main Scene으로 이동)
  - 조작법
  - 종료

### Main Scene
플레이어가 Controller를 이용하여 움직일 수 있는 Scene, 학교 3층에서 리스폰됩니다.<br>
- 주요 이벤트
  - 학교 내에 플레이어가 존재하면 5초 간격으로 일정 HP 감소
  - 불 오브젝트와 플레이어가 닿을경우 플레이어 HP 지속적인 감소 및 플레이어 HP Bar 빨간색으로 변경
  - 플레이어가 1층 비상구로 탈출 후 녹색원(Escape) 오브젝트에 닿을 시 VictoryScene으로 이동
    - 만약 플레이어의 HP가 다 닳을경우 Failed 화면과 사운드 재생 후 LoseScene으로 이동
<br>

### End Scene(Victory, Lose)
플레이어가 탈출하거나 하지 못할 경우 나오는 Scene, Oculus Controller를 이용하여 해당 버튼의 이벤트를 실행할 수 있습니다.
- 구성
  - 다시하기(Main Scene으로 이동)
  - 둘러보기(Tutorial Scene으로 이동)
  - 종료
  
### Tutorial Scene
내부 구성을 어떻게 했는지 체험할 수 있는 Scene, 플레이어의 HP가 존재하지 않으며 특수 이벤트도 다 제거된 Scene입니다.
<br><br>

### 후기
팀 프로젝트는 캡스톤디자인이 처음이었어서 어떻게 해야하나 구성하는데 시간이 오래 걸렸지만<br>
해당 프로젝트를 바탕으로 어떻게 팀과의 협동이 되어야 하나 경험이 된 프로젝트 입니다<br><br>

Unity와 VR을 처음 접하는 계기이다 보니 미숙한 부분이 많지만 자료를 많이 찾아보고 적용해보고 수 많은 수행착오 덕분에 완성 시킬 수 있게 되었습니다.
