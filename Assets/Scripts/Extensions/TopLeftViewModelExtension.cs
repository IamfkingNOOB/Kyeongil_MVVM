namespace ViewModel.Extensions
{
    public static class TopLeftViewModelExtension
    {
        public static void RefreshViewModel(this TopLeftViewModel vm)
        {
            int tempID = 2;

            GameLogicManager.Inst.RefreshCharacterInfo(tempID, vm.OnRefreshViewModel);
        }

        public static void OnRefreshViewModel(this TopLeftViewModel vm, int userID, string name, int level)
        {
            vm._userID = userID;
            vm.Name = name;
            vm.Level = level;
        }

        //public static void BindRegisterEventsOnEnable(this TopLeftViewModel vm, bool isRegister)
        //{
        //    if (isRegister)
        //    {
        //        GameLogicManager.Inst.RegisterLevelUpCallback(vm.OnResponseLevelUp);
        //    }
        //    else
        //    {

        //    }
        //}

        public static void RegisterEventsOnEnable(this TopLeftViewModel vm)
        {
            GameLogicManager.Inst.RegisterLevelUpCallback(vm.OnResponseLevelUp);
        }

        public static void UnRegisterEventsOnDisable(this TopLeftViewModel vm)
        {
            GameLogicManager.Inst.UnRegisterLevelUpCallback(vm.OnResponseLevelUp);
        }

        public static void OnResponseLevelUp(this TopLeftViewModel vm, int userID, int level)
        {
            if (vm._userID != userID)
            {
                return;
            }

            vm.Level = level;
        }
    }
}
