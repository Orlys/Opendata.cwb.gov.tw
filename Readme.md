## 台灣中央氣象局 REST API 封裝

[![Build status](https://ci.appveyor.com/api/projects/status/d5viju19wmj3tff6/branch/master?svg=true)](https://ci.appveyor.com/project/0x0001F36D/opendata-cwb-gov-tw/branch/master)
## 概觀
沒看到人寫C#版本的封裝，於是我就花了一些時間寫了這個。如果有錯誤或是你有更好的寫法，PR大力丟就對了!!!我看完沒問題就會合併了。

## 教學
1. 先登入 [氣象資料開放平台](https://opendata.cwb.gov.tw)
2. 按下 [此頁](https://opendata.cwb.gov.tw/devManual/insrtuction#getUserAuthkeyAnchor) 中的 ![取得授權碼](./img/getAuthCode.png) 取得右方的授權碼並複製
3. 複製下方的程式碼
```csharp
using Opendata.Core;
```
```csharp
// 建立連線物件
var client = new OpendataClient(apikey: "你的授權碼");
// 在 QueryBy 靜態類別中依照你所需要的 dataId 選出對應的查詢物件，以 F-C0032-001(一般天氣預報-今明 36 小時天氣預報) 為例
var subject = QueryBy.F_C0032_001; 
// 取回 Records, 你要的資料都在裡面
var records = client.GetAsync(queryBy: subject).Result;
```

## 版本
 - 1.0.0
 
## 安裝
 > 安裝已經發表至 [nuget.org](https://nuget.org)，在套件管理員中搜尋 **Opendata.Core** 即可
 - 使用 Package Manager
    ```
    Install-Package Opendata.Core -Version 1.0.0
    ```

## 參考
[中央氣象局開放資料平臺之資料擷取API](https://opendata.cwb.gov.tw/dist/opendata-swagger.html)

## 第三方套件
[Json.Net](https://www.newtonsoft.com/)

## 授權
[MIT License](./.license)