using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CSVReader : MonoBehaviour
{
    public string fileName; //�ɦW
    public string showData; //��playmaker�����줤�����
    public int totalEntries = 0; //����`��


    public void CheckCSVCount()
    {
        TextAsset csvFile = Resources.Load<TextAsset>(fileName); // Ū�� Resources ���� data.csv
        if (csvFile != null)
        {
            string csvData = csvFile.text; // ���o CSV ���¤�r���e
            string[] values = csvData.Trim().Split(','); // �H , ����
            totalEntries = values.Length;
        }
        else
        {
            Debug.LogError("CSV ��󥼧��");
        }
    }

    public void LoadCSVdata(int index)
    {
        TextAsset csvFile = Resources.Load<TextAsset>(fileName); // Ū�� Resources ���� data.csv
            string csvData = csvFile.text; // ���o CSV ���¤�r���e
            string[] values = csvData.Trim().Split(','); // �H , ����
            showData = values[index];


    }
}
