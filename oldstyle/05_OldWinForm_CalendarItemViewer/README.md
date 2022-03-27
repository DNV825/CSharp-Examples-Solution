# CalendarItemViewer

## セットアップ

デフォルトインストールされた古いMSBuildと.csprojファイルを利用してC#プログラムをコンパイルする例。MSBuildの配置場所は以下の通り。

`C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe`

以下のように利用する。なお、`-p:Configuration=Debug`は省略可能。具体的な指定方法は.csprojファイルを参照。

```shell
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:Build -p:Configuration=Debug
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:Build
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:Build -p:Configuration=Release
C:\プロジェクトフォルダ> 
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:Clean -p:Configuration=Debug
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:Clean
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:Clean -p:Configuration=Release
C:\プロジェクトフォルダ> 
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:ReBuild -p:Configuration=Debug
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:ReBuild
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild -t:ReBuild -p:Configuration=Release
```

## 使い方

出力した`CalendarItemViewer.exe`と同じフォルダに配置した`日付フォルダ/yyyymmdd`フォルダ内のアイテムを画面に表示し、5秒ごとに画面を更新する。
