// 플레이어의 뷰 모델(View Model)
using System.ComponentModel;
using System.Diagnostics;

public class MyPlayerViewModel : INotifyPropertyChanged
{
    private string _iconName;

    private int _playerID;
    private string _playerName;
    private int _playerLevel;

    #region Getter / Setter

    public string IconName
    {
        get { return _iconName; }
        set
        {
            if (_iconName != value)
            {
                _iconName = value;
                OnPropertyChanged(nameof(IconName));
            }
        }
    }

    public int PlayerID
    {
        get { return _playerID; }
        set
        {
            if (_playerID != value)
            {
                _playerID = value;
                OnPropertyChanged(nameof(PlayerID));
            }
        }
    }

    public string PlayerName
    {
        get { return _playerName; }
        set
        {
            if (_playerName != value)
            {
                _playerName = value;
                OnPropertyChanged(nameof(PlayerName));
            }
        }
    }

    public int PlayerLevel
    {
        get { return _playerLevel; }
        set
        {
            _playerLevel = value;
            OnPropertyChanged(nameof(PlayerLevel));
        }
    }

    #endregion Getter / Setter

    #region Property Changed Event

    // 속성(프로퍼티; Property)이 바뀌었을(set) 때 호출되는 이벤트 핸들러
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion Property Changed Event
}
