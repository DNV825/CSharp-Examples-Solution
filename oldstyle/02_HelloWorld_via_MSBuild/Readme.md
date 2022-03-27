# HelloWorld via MSBuild

更新日：2022/03/27(Sun) 17:49

## MSBuildを使ったビルド

デフォルトインストールされた古いMSBuildと.csprojファイルを利用してC#プログラムをコンパイルする例。MSBuildの配置場所は以下の通り。

`C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe`

以下のように利用する。なお、`-p:Configuration=Debug`は省略可能。具体的な指定方法は.csprojファイルを参照。

```shell
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:Build -p:Configuration=Debug
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:Build
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:Build -p:Configuration=Release
C:\プロジェクトフォルダ> 
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:Clean -p:Configuration=Debug
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:Clean
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:Clean -p:Configuration=Release
C:\プロジェクトフォルダ> 
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:ReBuild -p:Configuration=Debug
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:ReBuild
C:\プロジェクトフォルダ> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ターゲット.csproj -t:ReBuild -p:Configuration=Release
```

## 問題

ブレークポイントを利用したデバッグを行いたいが、現状できていない。`dotnet build`を実行する際のように、.dllファイルと.exeファイルを分ければ行けるか？
Microsoft.DiaSymReader.Converterのpdb2pdbでpdbファイルをportable版に置き換えれば動かせそうではあるが…。

## 参考資料

- ghogen / olprod / OpenLocalizationService / iamqinmu, チュートリアル: MSBuild プロジェクト ファイルのゼロからの作成, Microsoft Docs, 2021/11/19, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/walkthrough-creating-an-msbuild-project-file-from-scratch?view=vs-2022>
- ghogen / olprod / OpenLocalizationService, MSBuild, Microsoft Docs, 2021/11/25, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/msbuild?view=vs-2022>
- ghogen / olprod / OpenLocalizationService / Saisang, MSBuildリファレンス, Microsoft Docs, 2021/08/19, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/msbuild-reference?view=vs-2022>
- ghogen / olprod / OpenLocalizationService / Saisang, MSBuildのマルチターゲットの概要, Microsoft Docs, 2021/10/23, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/msbuild-multitargeting-overview?view=vs-2022>
- TerryGLee / olprod / OpenLocalizationService, フレームワーク対象設定機能の概要, Microsoft Docs, 2022/01/28, <https://docs.microsoft.com/ja-jp/visualstudio/ide/visual-studio-multi-targeting-overview?view=vs-2022>
- ghogen / olprod / OpenLocalizationService, MSBuild ターゲット フレームワークおよびターゲット プラットフォーム, Microsoft Docs, 2021/08/20, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/msbuild-target-framework-and-target-platform?view=vs-2022>
- ghogen / olprod / OpenLocalizationService / iamqinmu, CSCタスク, Microsoft Docs, 2021/11/25, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/csc-task?view=vs-2022>
- ghogen / olprod / Saisang / OpenLocalizationService, RemoveDir タスク, Microsoft Docs, 2021/08/20, <https://docs.microsoft.com/ja-jp/visualstudio/msbuild/removedir-task?view=vs-2022>
- Nobuyuki Iwanaga, 新しいcsproj形式,  ++C++ // 未確認飛行 C, 2017/05/12, <https://ufcpp.net/blog/2017/5/newcsproj/>
- かわさき しんじ, 第3回　Visual Studio CodeでC#コードをデバッグするための構成ファイル設定の基本, @IT, 2017/09/01, <https://atmarkit.itmedia.co.jp/ait/articles/1709/01/news034_3.html>
- RomainHautefeuille , Configuring launch.json for C# debugging, OmniSharp / omnisharp-vscode, 2021/12/10, <https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger-launchjson.md>
- 一色 政彦, 特集 MSBuild完全攻略（前編） .NETビルド・エンジン「MSBuild」使いこなし術, @IT, 2006/04/15, <https://atmarkit.itmedia.co.jp/fdotnet/special/msbuild01/msbuild01_02.html>
- 一色 政彦, 特集 MSBuild完全攻略（後編） ビルド・エンジン「MSBuild」を思いのままに操る技, @IT, 2006/05/13, <https://atmarkit.itmedia.co.jp/fdotnet/special/msbuild02/msbuild02_02.html>
- tmat / v-zbsail / mmitche / github-john-doe / jonfortescue / terrajobst / cristianosuzuki77 / akoeplinger / jimmymasaru / dotnet-bot / mikem8361 / JohnTortugo / richlander / nguerrera / v-mdriml, Microsoft.DiaSymReader.Converter, dotnet / symreader-converter, 2022/03/21, <https://github.com/dotnet/symreader-converter>