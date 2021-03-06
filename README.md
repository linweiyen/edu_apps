# 起源
發現在這網路的時代，要孩子拿筆門檻越來越高，他們非常喜歡利用 3C 進行資訊的讀取，在背誦英文單字的需求下，很難要求他們利用筆寫的方式來背單字，故突發奇想想撰寫一個小程式協助孩子背誦英文單字。

# 不開發直接使用
## 直接執行
- (1) 下載 [english_learning_exe.zip](https://github.com/linweiyen/edu_apps/blob/main/english_learning_exe.zip)，並解壓縮
- (2) 執行 english_learning.exe
- (3) 如果系統未安裝 .Net Core 3.1，會跳出視窗要求安裝，安裝完後再執行 english_learning.exe 即可

## 修改詞庫
- 壓縮包內有一個 database.csv 檔案，為程式詞庫，可以利用 Notepad++ 修改，也可以用 database.xlsx 修改，之後另存為 csv 檔案，但要使用 UTF-8 編碼

## 重要邏輯
- 程式會根據詞庫按照順序出中文，孩子輸入英文，若是一次就填寫正確，資訊會記錄在 correct_words.txt 之中，可以勾選 "略過已正確答對文字"，不再回答這些字，以達到快速篩選不熟的單字的功能
- 如果不會拼，可以選擇 "認錯"，將強迫孩子填寫五次，才能關閉視窗繼續執行，已經鎖掉 TextBox 複製貼上的功能，必需要確確實實的輸入五次
- 如果該單字想暫時略過，可以選擇 "跳過"，先不回答
- 想重來，可以點選 "重來"
- 會根據孩子回答紀錄，顯示 答對字數/答過字數
- 可以利用 "篩選分類" 的功能，針對特別分類的字加強，例如：顏色﹑動物....



# 開發說明
利用 Visual Studio 2019 Community 開發，程式碼非常簡短，因為只是想讓孩子學習，故系統設計非常陽春且簡單。