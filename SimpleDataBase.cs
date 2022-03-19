namespace modul4_1302204035;

public class SimpleDataBase<T,Date>
{
    private List<T> storedData;
    private List<Date> storedDate;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        storedDate = new List<Date>();
    }
    
    public void AddData(T data, Date date)
    {
        storedData.Add(data);
        storedDate.Add(date);
    }

    public void PrintAllData()
    {
        for (int i = 1; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC:" + storedDate[i]);
        }
    }
}