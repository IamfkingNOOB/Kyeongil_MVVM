// 플레이어의 정보(데이터)를 가지는 클래스, 정보만을 가지기 때문에 모델(Model)이다.
public class MyPlayerModel
{
    // 플레이어의 정보(데이터)
    public int PlayerID { get; private set; } // 플레이어의 ID
    public string PlayerName { get; private set; } // 플레이어의 이름
    public int PlayerLevel { get; set; } // 플레이어의 레벨

    // 생성자(Constructor)
    public MyPlayerModel(int playerID, string playerName, int playerLevel)
    {
        PlayerID = playerID;
        PlayerName = playerName;
        PlayerLevel = playerLevel;
    }
}
