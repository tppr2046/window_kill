using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    public string fileName; //檔名
    public string showData; //讓playmaker抓到欄位中的資料
    public int totalEntries = 0; //資料總數


    public void CheckCSVCount()
    {
        TextAsset csvFile = Resources.Load<TextAsset>(fileName); // 讀取 Resources 內的 data.csv
        if (csvFile != null)
        {
            string csvData = csvFile.text; // 取得 CSV 的純文字內容
            string[] values = csvData.Trim().Split(','); // 以 , 分割
            totalEntries = values.Length;
        }
        else
        {
            Debug.LogError("CSV 文件未找到");
        }
    }

    public void LoadCSVdata(int index)
    {
        TextAsset csvFile = Resources.Load<TextAsset>(fileName); // 讀取 Resources 內的 data.csv
            string csvData = csvFile.text; // 取得 CSV 的純文字內容
            string[] values = csvData.Trim().Split(','); // 以 , 分割
            showData = values[index];


    }
}
