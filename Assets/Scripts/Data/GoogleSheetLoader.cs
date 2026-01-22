using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks; 
using System;

public class GoogleSheetLoader : MonoBehaviour
{
    string url = "https://docs.google.com/spreadsheets/d/e/2PACX-1vRdOE-2ka_A0F0bOd8DJqxV-xbA-h3Nx-hrWU6uWkO-7V3e33wmkHjEn4U3LETEYcTZt9N0cDBqCoHG/pub?gid=0&single=true&output=csv";


    async void Start()
    {
        try
        {
            string csvData = await DounLoadCSVAsync();
            ProcessData(csvData);
        }
        catch (Exception ex)
        {
            Debug.LogError($"데이터 로드 중 에러 발생함: {ex.Message}");
        }
    }

    async Task<string> DounLoadCSVAsync()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(url))
        {
            var opertion = www.SendWebRequest();

            while (!opertion.isDone)
                await Task.Yield();

            if (www.result == UnityWebRequest.Result.Success)
                return www.downloadHandler.text;
            else
                throw new Exception(www.error);
        }
    }

    void ProcessData(string csvText)
    {
        string[] lines = csvText.Split('\n');

        for(int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;

            string[] row = lines[i].Split(',');

            int monsterNum = int.Parse(row[0]);
            int hp = int.Parse(row[1]);
            float speed = float.Parse(row[2]);
            string monsterSprite = row[3].Trim();
            string effct = row[4].Trim();

            Debug.Log($"{monsterNum}번 몬스터 로드 완료! 체력: {hp}, 속도: {speed}");
        }
    }
}
