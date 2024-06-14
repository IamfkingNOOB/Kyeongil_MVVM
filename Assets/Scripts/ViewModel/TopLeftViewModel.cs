using System.ComponentModel;

public class TopLeftViewModel
{
    public int _userID { get; set; }
    private string _name;
    private int _level;
    private string _iconName;

    #region Getter / Setter

    //public int UserID
    //{
    //    get { return _userID; }
    //    set { _userID = value; }
    //}

    public string Name
    {
        get { return _name; }
        set
        {
            // 값이 동일할 경우에는 이후의 처리를 하지 않는다.
            if (_name == value) return;

            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    public int Level
    {
        get { return _level; }
        set
        {
            if (_level == value) return;

            _level = value;
            OnPropertyChanged(nameof(Level));
        }
    }

    public string IconName
    {
        get { return _iconName; }
        set
        {
            if (_iconName == value) return;

            _name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    #endregion Getter / Setter

    #region Property Changed Event

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion Property Changed Event
}
