using System;

// 게임의 논리를 관리하는 클래스
public class MyGameLogicManager
{
    // 싱글톤(Singleton) 패턴
    private static MyGameLogicManager instance;
    public static MyGameLogicManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MyGameLogicManager();
            }
            return instance;
        }
    }

    #region Callbacks

    // 플레이어 모델의 정보(데이터)에 접근하는 콜백 이벤트, UI(View)가 참조하는 뷰 모델(View Model)의 이벤트에 구독할 대리자
    // Action<int(PlayerID), var(플레이어의 정보)>
    private Action<int, string> _renameCallback; // 플레이어의 이름(string)을 바꾸는 함수
    private Action<int, int> _levelUpCallback; // 플레이어가 레벨(int) 업을 하는 함수

    public void RegisterRenameCallback(Action<int, string> renameCallback) // 플레이어의 이름을 바꾸는 콜백 함수를 등록한다.
    {
        _renameCallback += renameCallback;
    }

    public void UnregisterRenameCallback(Action<int, string> renameCallback) // 플레이어의 이름을 바꾸는 콜백 함수를 해제한다.
    {
        _renameCallback -= renameCallback;
    }

    public void RegisterLevelUpCallback(Action<int, int> levelUpCallback) // 플레이어의 레벨 업을 하는 콜백 함수를 등록한다.
    {
        _levelUpCallback += levelUpCallback;
    }

    public void UnregisterLevelUpCallback(Action<int, int> levelUpCallback) // 플레이어의 레벨 업을 하는 콜백 함수를 해제한다.
    {
        _levelUpCallback -= levelUpCallback;
    }

    #endregion Callbacks

    #region Methods

    public void Rename(MyPlayerModel myPlayerModel, string newName) // 플레이어의 이름을 바꾸는 함수
    {
        // 문자열 값을 받아, 플레이어의 이름을 바꾼다.
        myPlayerModel.PlayerName = newName;
        _renameCallback?.Invoke(myPlayerModel.PlayerID, myPlayerModel.PlayerName);
    }

    public void LevelUp(MyPlayerModel myPlayerModel) // 플레이어가 레벨 업을 하는 함수
    {
        // 플레이어의 정보를 받아, 플레이어의 레벨을 올린다.
        myPlayerModel.PlayerLevel += 1;
        _levelUpCallback?.Invoke(myPlayerModel.PlayerID, myPlayerModel.PlayerLevel);
    }

    public void UpdateCharacterInfo(MyPlayerModel myPlayerModel) // 플레이어의 정보를 갱신하는 함수
    {
        
    }

    #endregion Methods
}
