using CsvHelper;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

public class Foo
{
    public int id { get; set; }
    public string name { get; set; }
}
public class TEst : MonoBehaviour
{
    // �츮�� �ؽ�Ʈ ���� ��δ� 
    // Assets/Resources/Data.csv

    private void Start()
    {
        TextAsset csvFile = Resources.Load<TextAsset>("Data");
        using(var reader = new StringReader(csvFile.text))
        using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Foo>();

            foreach(var record in records)
            {
                Debug.Log($"{record.id}, {record.name}");
            }
        }
    }
}
