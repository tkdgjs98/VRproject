# VRproject

- 설명 : 대학교의 강의 중에 팀원 3명과 같이 만들었던 VR 게임으로, 밴드부 팀원의 아이디어를 통해 만들었던 악기 연주 시뮬레이터입니다.

  악기 종류는 드럼, 피아노 2가지가 있는데 드럼은 컨트롤러를 드럼스틱처럼 사용하여 기능하고, 피아노 같은 경우는 Occulus 기본 탑재 기능 중에 핸드 트래킹 기능을 이용하여 피아노의 기능을 구현했습니다.

  게임 그래픽은 드럼은 무료 배포 에셋을 사용했으나, 피아노의 경우에는 유료 에셋을 팀원들과 비용을 배분하여 구매하여 진행했습니다.

- 시스템 구성
  - 드럼 연주
    (VR 환경 내에서) 드럼 스틱과 드럼이 충돌했을 때 소리를 출력
    
    드럼 스틱 속도에 따른 소리 크기 변화
    
    현실 소리와 유사하게 하기 위해 드럼소리에 랜덤 주파수(pitch) 적용
    
    발로 연주하는 베이스 드럼은 컨트롤러 버튼으로 소리 출력
    
  - 키보드 연주
  
    (VR 환경 내에서) 핸드 트래킹된 손과 건반이 충돌했을 때 소리를 출력
    
    Poke Interaction 사용하려 했지만, 한 손가락밖에 안 되기 때문에 몰입감 방해 → collision으로 구현
    
    오디오 믹서를 사용해 옥타브 별 ‘도(C)’ 음을 pitch 조절하여 모든 음 표현
    
    건반이 눌리는 애니메이션 추가

- 게임 플레이 영상
  
  

https://github.com/tkdgjs98/VRproject/assets/89759616/fb4ff330-11ce-4308-97d4-5760624e5f1d


