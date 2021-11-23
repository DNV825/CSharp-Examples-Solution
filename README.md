# CSharp-Examples-Solution

C\#の勉強・練習・確認メモのプロジェクト。

## Dependency

- [Visual Studio Code](https://azure.microsoft.com/ja-jp/products/visual-studio-code/) 任意のバージョン
  - Visual Studio Codeの拡張プラグイン「C\#」（作者：Microsoft）
- [.NET 5以降](<https://dotnet.microsoft.com/download>) バージョン5以降

アプリをインストールできるのであれば、Visual Studio Codeと「.NET 5」以降をインストールする。

この2つのアプリは商用利用が可能なので安心して利用できる。個人向けツールを作る程度であれば、Visual Studio Codeで十分すぎる性能だろう。

ちなみに、フリーのVisual Studioである「Visual Studio Community」は規約で商用利用不可の条件が定められており、大抵の現場が利用不可の条件に接触する。うっかり利用しないこと！

> マイクロソフト ソフトウェア ライセンス条項
>
> MICROSOFT VISUAL STUDIO COMMUNITY 2019
>
> （省略）
>  
> b. 組織ライセンス。お客様が組織である場合、お客様のユーザーは以下の条件で本ソフトウェアを使用することができます。
>
> （省略）
>
> - お客様がエンタープライズである場合、お客様の従業員および契約社員は本ソフトウェアを使用して、お客様のアプリケーションを開発またはテストすることはできません。ただし、上記で許可されている (i) オープンソース、(ii) Visual Studio の拡張機能、(iii) Windows オペレーティング システムのデバイス ドライバー、(iv) SQL Server の開発、および (v) 教育目的の場合を除きます。
>
> > 「エンタープライズ」とは、合計で (a) 250 台を超える PC がある、もしくは 250 人を超えるユーザーがいる、または (b) 年間収益が 100 万米ドル (もしくは他の通貨での相当額) を超える、組織およびその関連会社のことです。「関連会社」とは、組織を (過半数所有により) 支配している法人、組織が支配している法人、または組織と共通の支配下にある法人を意味します。
>
> <https://visualstudio.microsoft.com/ja/license-terms/mlt031819/>

例えば、3人で始めたスタートアップ企業を想像すると、最初は条件に引っかからないのでCommunity版を使えるが、事業が軌道に乗り次第「`もしくは 250 人を超えるユーザーがいる`」に接触し、Pro版に切り替えなければいけなくなるだろう（「ユーザー」は従業員や派遣社員・アルバイトのことだと認識している。）

## Setup

### Visual Studio Codeをインストールする

以下のリンクからVisual Studio Codeをインストールする。

<https://azure.microsoft.com/ja-jp/products/visual-studio-code/>

#### Visual Studio Codeの拡張機能「C\#」をインストールする

Visual Studio Codeで拡張機能「C\#（作成者：Microsoft）」を検索し、インストールする。この拡張機能をインストールすることで、インテリセンスを利用できるようになる。

### .NET 5以降をインストールする

以下のリンクから「.NET 5」以降をダウンロードし、インストールする。

<https://dotnet.microsoft.com/download>

#### .NETの種類について

「.NET」、「.NET Core」、「.NET Framework」の3つがあるが、「.NET」を選択すること。それぞれが意味するものは以下の通り。

| .NETの種別 | 意味 |
| --- | --- |
| .NET | .NET Core と .NET Framework を統合したもの |
| .NET Core | クロスプラットフォーム向けの .NET |
| .NET Framework | Windows向けの .NET |

「.NET」それ自体については以下を参照。

- NETの概要
<https://docs.microsoft.com/ja-jp/dotnet/core/introduction>
- C\# - 再統合された .NET:.NET 5 に関する Microsoft の計画
<https://docs.microsoft.com/ja-jp/archive/msdn-magazine/2019/july/csharp-net-reunified-microsoft%E2%80%99s-plans-for-net-5>

#### Framework Class Library

.Net FrameworkはFramework Class Library（FCL）というライブラリを備えており、この要素を組み合わせることによって様々なアプリケーションを比較的容易に構築することができる。

| Framework Class Library | できること |
| --- | --- |
| WPF | Windows上で実行されるGUIアプリケーション |
| Windowsフォーム | ^ |
| コンソールアプリケーション | コンソール上で実行されるアプリケーション |
| ASP .NET | Webブラウザー経由で利用するWebアプリケーションフレームワーク |

### 動作確認

以下の資料に従い、コンパイル＆実行できることを確認する。

- チュートリアル: Visual Studio Code を使用して .NET コンソール アプリケーションを作成する
<https://docs.microsoft.com/ja-jp/dotnet/core/tutorials/with-visual-studio-code>

## .NET 5以降/Coreを利用するためのコマンド

.NET 5 以降、および .NET Coreを利用するための`dotnet`コマンドが用意されている。`dotnet`コマンドのヘルプで詳細を確認できるし、Web上のリファレンスにより詳しい説明が書かれている（<https://docs.microsoft.com/ja-jp/dotnet/core/tools/>）

以下の表は一部を抜粋したもの。

| コマンド | 意味 |
| --- | --- |
| dotnet --version | .NET のバージョンを表示する。 |
| dotnet new console | .NET コンソールアプリプロジェクトを作成する。 |
| dotnet new console -o 配置場所 | 配置場所を指定して .NET コンソールアプリプロジェクトを作成する。-oではなく、--outputを指定しても良い。<br>例：`dotnet new console -o ShowCase` |
| dotnet new sln | 空のソリューションを作成する。 |
| dotnet new classlib -o 配置場所 | .NET クラスライブラリプロジェクトを作成する。<br>例：`dotnet new classlib -o StringLibrary` |
| dotnet sln add 配置場所/プロジェクト名.csproj | 任意のプロジェクトをソリューションに追加する。<br>例：`dotnet sln add StringLibrary/StringLibrary.csproj`<br>例：`dotnet sln add ShowCase/ShowCase.csprj` |
| dotnet build | ソリューションをビルドする。 |
| dotnet add 配置場所/参照元プロジェクト名.csproj reference 配置場所/参照先プロジェクト名.csproj | 参照元プロジェクトに参照先プロジェクトのプロジェクト参照を追加する。<br>例：`dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj` |
| dotnet run | コンソールアプリを実行する。 |
| dotnet run --project | プロジェクト名を指定してコンソールアプリを実行する。<br>例：`dotnet run --project ShowCase/ShowCase.csproj` |
| dotnet run --configuration Release | コンソールアプリのリリースバージョンをテストする。 |
| dotnet new mstest -o 配置場所 | MSTestによる単体テストプロジェクトを作成する。<br>例：`dotnet new mstest -o StringLibraryTest` |
| dotnet test 配置場所/テストプロジェクト名.csproj | MSTestを実行する。<br>例：`dotnet test StringLibraryTest/StringLibraryTest.csproj` |
| dotnet test 配置場所/テストプロジェクト名.csproj --configuration Release | リリースビルド構成でMSTestを実行する。<br>例：`dotnet test StringLibraryTest/StringLibraryTest.csproj --configuration Release` |
| dotnet publish --configuration Release | コンソールアプリをリリースビルド構成で発行する。 |

## チュートリアル

- チュートリアル: Visual Studio Code を使用して .NET コンソール アプリケーションを作成する
<https://docs.microsoft.com/ja-jp/dotnet/core/tutorials/with-visual-studio-code>
- Visual Studio Codeを使ったデバッグ
<https://code.visualstudio.com/Docs/editor/debugging>

余談

C\# 9以降はコンソールアプリケーションプロジェクトに`Main()`メソッドを明示的に含めなくてもよくなったそうだ。すごい。
Azure FunctionsやGitHub Actionsに気軽に対応するためにそうなったみたい。

<https://docs.microsoft.com/ja-jp/dotnet/csharp/fundamentals/program-structure/top-level-statements>

## 開発の流れについて

1. プロジェクトを作成する。
1. ソースコードを記述する。
1. プロジェクトをビルドする。
1. 必要に応じてプロジェクトをデバッグする。
1. アプリを発行する。

## デバッグについて

`System.Diagnostics.Debug.Print();`でデバッグログを出力できる。

## 発行について

`PublishSingleFile`・`SelfContained`・`RuntimeIdentifier`を指定して`dotnet publish`を実行すると、RuntimeIdentiferで指定したランタイム識別子のフォルダに1つにまとめたexeファイルを出力できる。
複数のランタイム識別子を指定する場合は`RuntimeIdentifiers`にセミコロンで区切って指定する。

- 発行の概要
<https://docs.microsoft.com/ja-jp/dotnet/core/deploying/>
- ビルドと発行の違い
<https://www.petitmonte.com/bbs/answers?question_id=27514>

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net5.0-windows</TargetFramework>
    <UseWPF>true</UseWPF>
    <!-- 以下の3行で発行（publish）時に単一のexeファイル出力にできる。ただし、通常のデバッグ時にはコメントアウトすること。 -->
    <PublishSingleFile>true</PublishSingleFile>
    <SelfContained>false</SelfContained>
    <RuntimeIdentifier>win-x64</RuntimeIdentifier>
    <!-- exeファイルのアイコンを指定する。 -->
    <ApplicationIcon>img/icon32x32a.ico</ApplicationIcon>
  </PropertyGroup>
  
  <ItemGroup>
    <!-- ビルド後にファイルを出力しない、という設定。これを書かないと相対パスが認識されない。 -->
    <None Remove="img/icon32x32a.ico" />
  </ItemGroup>

  <ItemGroup>
    <!-- 埋め込みリソースとする指示。 -->
    <EmbeddedResource Include="img/icon32x32a.ico" />
  </ItemGroup>
</Project>
```

なんやかんや言って、windowsで使うだけならファイルパスは"\\"区切りにしたほうが良い。
linuxとかも含めて使うなら"/"を使うのがいいけど、結局OSで区別しなきゃならんのではなかろうか。

## 単体テストについて

<https://docs.microsoft.com/ja-jp/dotnet/core/tutorials/testing-library-with-visual-studio-code>
<https://docs.microsoft.com/ja-jp/dotnet/core/testing/unit-testing-best-practices>

xunitのターゲットフレームワークがnet5.0なので、ImageScreenerに合わせてnet5.0-windowsにしてみた。
単体テストは値や例外の検査を行うもの。GUI表示がどうなっているのか、といった検査はできない。
それはUIテスト。

## UIテストについて

Visual Studioを使わないと実質無理？

<https://docs.microsoft.com/ja-jp/dotnet/core/project-sdk/msbuild-props>

## Tips

```shell
C:\workspace\development\project\ImageScreener\ImageScreener>dotnet add package WindowsAPICodePack-Shell
  復元対象のプロジェクトを決定しています...
  Writing C:\Users\Aki\AppData\Local\Temp\tmp4FF0.tmp
info : パッケージ 'WindowsAPICodePack-Shell' の PackageReference をプロジェクト 'C:\workspace\development\project\ImageScreener\ImageScreener\ImageScreener.csproj' に追加しています。
info :   GET https://api.nuget.org/v3/registration5-gz-semver2/windowsapicodepack-shell/index.json
info :   OK https://api.nuget.org/v3/registration5-gz-semver2/windowsapicodepack-shell/index.json 717 ミリ秒
info : C:\workspace\development\project\ImageScreener\ImageScreener\ImageScreener.csproj のパッケージを復元しています...
info :   GET https://api.nuget.org/v3-flatcontainer/windowsapicodepack-shell/index.json
info :   OK https://api.nuget.org/v3-flatcontainer/windowsapicodepack-shell/index.json 710 ミリ秒
info :   GET https://api.nuget.org/v3-flatcontainer/windowsapicodepack-shell/1.1.1/windowsapicodepack-shell.1.1.1.nupkg
info :   OK https://api.nuget.org/v3-flatcontainer/windowsapicodepack-shell/1.1.1/windowsapicodepack-shell.1.1.1.nupkg 11 ミリ秒
info :   GET https://api.nuget.org/v3-flatcontainer/windowsapicodepack-core/index.json
info :   OK https://api.nuget.org/v3-flatcontainer/windowsapicodepack-core/index.json 711 ミリ秒
info :   GET https://api.nuget.org/v3-flatcontainer/windowsapicodepack-core/1.1.1/windowsapicodepack-core.1.1.1.nupkg
info :   OK https://api.nuget.org/v3-flatcontainer/windowsapicodepack-core/1.1.1/windowsapicodepack-core.1.1.1.nupkg 14 ミリ秒
info : コンテンツ ハッシュ CPFamhL3jPo8O6+ErGsLS4LK3DWP5ncxqhbzpPnYkIW9rjatunUij35iTjprbr9mlYR/5Pbguw21MwSmTOKR4g== の https://api.nuget.org/v3/index.json から WindowsAPICodePack-Shell 1.1.1 がインストールされました。
info : コンテンツ ハッシュ GoURoQuE7ea7B7q24YRTBfZbsNO7ZtwSyBHbM8zO0ynwfjAGC0bbAmVrDvZ6HbWtqqOt6QTzdmYnj2WJglb5JQ== の https://api.nuget.org/v3/index.json から WindowsAPICodePack-Core 1.1.1 がインストールされました。
warn : NU1701: パッケージ 'WindowsAPICodePack-Core 1.1.1' はプロジェクトのターゲット フレームワーク 'net5.0-windows7.0' ではなく '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8' を
使用して復元されました。このパッケージは、使用しているプロジェクトとの完全な互換性がない可能性があります。
warn : NU1701: パッケージ 'WindowsAPICodePack-Shell 1.1.1' はプロジェクトのターゲット フレームワーク 'net5.0-windows7.0' ではなく '.NETFramework,Version=v4.6.1, .NETFramework,Version=v4.6.2, .NETFramework,Version=v4.7, .NETFramework,Version=v4.7.1, .NETFramework,Version=v4.7.2, .NETFramework,Version=v4.8'  
を使用して復元されました。このパッケージは、使用しているプロジェクトとの完全な互換性がない可能性があります。
info : パッケージ 'WindowsAPICodePack-Shell' は、プロジェクト 'C:\workspace\development\project\ImageScreener\ImageScreener\ImageScreener.csproj' のすべて
の指定されたフレームワークとの互換性があります。
info : ファイル 'C:\workspace\development\project\ImageScreener\ImageScreener\ImageScreener.csproj' に追加されたパッケージ 'WindowsAPICodePack-Shell' バー
ジョン '1.1.1' の PackageReference。
info : 復元をコミットしています...
info : アセット ファイルをディスクに書き込んでいます。パス: C:\workspace\development\project\ImageScreener\ImageScreener\obj\project.assets.json
log  : C:\workspace\development\project\ImageScreener\ImageScreener\ImageScreener.csproj を復元しました (2.61 sec)。

C:\workspace\development\project\ImageScreener\ImageScreener>dotnet remove  package WindowsAPICodePack-Shell
info : パッケージ 'WindowsAPICodePack-Shell' の PackageReference をプロジェクト 'C:\workspace\development\project\ImageScreener\ImageScreener\ImageScreener.csproj' から削除しています。
```

パッケージの実体は`C:\Users\ユーザー名\.nuget\packages`に保存されるので、不要なパッケージは直接削除すればよい（削除コマンドは存在しないっぽい。）

## References

1. 高江 賢, 基礎からしっかり学ぶC\#の教科書 C\# 7対応, 日経BP社, 2018/01/31 第1版, ASIN:B079LY2P4R/ISBN:978-4-8222-9894-4
1. Tom Dykstra / olprod / Lucas / Hiroshi Yoshioka / OpenLocalizationService,  チュートリアル: Visual Studio Code を使用して .NET コンソール アプリケーションを作成する, .NET - .NETの基礎, 2020/11/17, <https://docs.microsoft.com/ja-jp/dotnet/core/tutorials/with-visual-studio-code>
1. @mtm3qi, 「.Net Framework」と「.Net Core」の違い、そして「.Net 5」, Qiita, 2020/01/05, <https://qiita.com/mtm3qi/items/28cd4c2da77008b0892c>
1. -, ［速報］マイクロソフト「.NET 5」正式リリース。1つのフレームワークでWindows／Mac／Linuxのデスクトップ、サーバアプリ、Webアプリなどが開発可能に, Publickey, 2020/11/11, <https://www.publickey1.jp/blog/20/net_51windowsmaclinuxweb.html>
1. Andy (Steve) De George / olprod / OpenLocalizationService, .NET アプリケーションの発行の概要, .NET - .NET の基礎, 2021/02/05, <https://docs.microsoft.com/ja-jp/dotnet/core/deploying/>
