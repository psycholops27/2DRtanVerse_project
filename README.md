# 2DRtanVerse_project
251022~251028 Sparta Coding Club homework
---------------------------------------

### 씬 구성
- MainSquare: 플레이어 캐릭터가 움직일 수 있는 메인 공간
- FlappyPlane: (미니 게임)장애물 회피 미니 게임
- TheStack: (미니 게임)블록 쌓기   
---------------------------------------
​
### 스크립트 구성
- **CameraController**       :   target(플레이어)를 따라 카메라가 이동하도록 하는 스크립트
- **CollisionController**    :   특정 태그를 가진 GameObject와 접촉 시 특정 기능을 수행하게 하는 스크립트
- **EnterMiniGame**          :   Inspector 창에서 Scene Name을 결정할 수 있게 하는, CollisionController의 보조 스크립트
- **PlayerController**       :   Player(플레이어 캐릭터)의 2D 조작을 가능하게 하는 스크립트
- **ScoreManager**           :   전체 미니게임의 스코어를 관리하는 스크립트
- **ScoreUpdate**            :   MainSquare의 ScoreUI가 켜질 때마다 점수를 업데이트하는 스크립트
- **TriggerController**      :   플레이어가 트리거 영역 위에 올라왔을 때 특정 기능을 수행하게 하는 스크립트
<br><br>
- **FlappyManager**          :   FlappyPlane의 GameManager
- **FPBGLooper**             :   배경과 오브젝트들이 반복될 수 있도록 하는 스크립트
- **FPFollowCamera**         :   카메라가 비행기(플레이어 오브젝트)를 따라오도록 하는 스크립트
- **FPObstacle**             :   장애물 위치를 랜덤으로 조정하는 스크립트
- **FPPlayer**               :   비행기의 2D 조작을 가능하게 하는 스크립트
- **FPUIManager**            :   FlappyPlane의 UI 표시를 관리하는 스크립트
<br><br>
- **StackManager**           :   TheStack의 GameManager
- **TSUIManager**            :   The Stack의 UI 표시를 관리하는 스크립트
- **BaseUI**                 :   하위 UI들이 상속받아야 하는 부모 클래스 스크립트
- **HomeUI**                 :   미니게임 시작화면 UI 관련 스크립트
- **GameUI**                 :   미니게임 플레이화면 UI 관련 스크립트
- **ScoreUI**                :   미니게임 게임 오버 화면 UI 관련 스크립트
- **DestroyZone**            :   바닥으로 떨어진 GameObject들을 제거해주는 스크립트
