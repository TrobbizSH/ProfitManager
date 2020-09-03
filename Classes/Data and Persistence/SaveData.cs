namespace ProfitManager.Classes.Data_and_Persistence
{
    public struct SaveData
    {
        public string incomeText, spentText;

        public SaveData(string _incomeText, string _spentText)
        {
            incomeText = _incomeText;
            spentText = _spentText;
        }
    }
}