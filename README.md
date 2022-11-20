# DoubleMeTset_Choijaeho
DoubleMe Unity Test\
최재호

구현 완료한 과제 List (6/6)
---
1. 미션 하나 추가로 넣기
2. 캐릭터 Accessory 아이템 하나 넣기 
3. 슬라이딩이나 점프 성공 시 \
   3-1. 캐릭터 스피드가 점점 빨라지고 장애물에 닿을 시 원래 스피드로 돌아온다.\
   3-2. 콤보 UI가 화면에 생성이 되고 콤보 숫자가 점점 올라간다.
4. 스코어 배수에 따라 물고기 코인도 배수만큼 늘어난다. 
5. 장애물 하나 새로 만들어서 런타임 중에 생성되게 만들기 
6. PowerUpItem 하나 프리펩으로 만들어서 상점에 넣고, 게임이 시작되면 인게임에서 생성이 되거나 사용하기


어려웠던 점 및 해결방법
---
1. 그동안 게임 구현 시 처음부터 제작 하거나 다른 사람이 구현한 기능 중 일부를 응용하여 구현 해온 관계로 완성된 게임에 컨텐츠를 추가하는 작업은 익숙하지 않았다.\
    해결방법 : 처음부터 기능을 구현하기보다는 기존 게임의 코드간의 연계를 파악하는데 시간을 사용하였고, 후에 기능 구현시 응용할 수 있는 부분을 집중적으로 파악하였다.
2. 과제 3번 장애물(Barrier)이 지나갔는지 감지하는 기능 구현 시 플레이어 위치를 기준으로 발사되는 Ray를 사용하여 Barrier의 Colider를 감지하려 하였으나, 플레이어 속도값이 20이상이 되면 때때로 Colider가 감지되지 않고 지나가는 오류를 발견하였다.\
    해결방법 : 감지하는 영역이 Line인 Ray 대신에 OverlapBox를 활용하여 놓치는 Colider가 없도록 구현하였다.
4. 깃허브 커밋과정에서 CRLL,LF 관련한 줄 끝 처리과정의 오류가 발생하였다.\
    해결방법 : 구글링을 통해 Windows에서 사용할때 처리하는 줄 끝의 전역설정을 추가해주었다.

느낀점 :\
주석의 필요성을 다시 한 번 느끼게되는 계기가 되었습니다.\
감사합니다.
