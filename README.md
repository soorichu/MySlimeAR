## MySimpleAR

Required Package Manager
- AR Foundation 4.1.1
- ARCore XR Plugin 4.1.1
- ARKit XR Plugin 4.1.1
- XR Plugin Management 3.2.16

AR 동작 방식
1. AR Session 요청
2. 카메라 하드웨어 켠다
3. IMU 하드웨어 켠다
4. Camera와 Motion Sensor는 ARFrame 마다 값을 업데이트
5. AR Session 열린다.
(이 순간, 카메라 위치를 원점으로 가상 월드 좌표계 생성)
6. 그 좌표계에서 VIO를 통해 현재 카메라의 위치와 회전값을 업데이트
7. 카메라 이미지를 분석해서 물체 감지
8. 등록된 사물이 아니면, 새로운 앵커를 만들어서 사물을 위치시킨다.
9. 이미 등록된 사물이면, 업데이트 또는 병합
10. 7-9 과정을 반복

https://gaudiolab.com/mobile-ar-in-unity-part-1-ar/?lang=ko

AR Session Origin
- AR Session을 요청하기 위해서 필요
- AR Session에 오는 가상환경의 추적요소들을 크기 및 방향 등을 세팅해줌. 

Build 방법(중요)
https://13-32.tistory.com/entry/%EC%9C%A0%EB%8B%88%ED%8B%B0Unity-AR-Foundation-SDK-%EC%82%AC%EC%9A%A9-%EB%B0%8F-%EA%B5%AC%ED%98%84-%EB%B0%A9%EB%B2%95
- AR Camera를 Main Camera로 설정(태그)
- Vulkan Graphics API 삭제
- Min API Android 7.0 Nougat
- XR Plug-in Manager에서 ARCore 체크