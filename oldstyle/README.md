# C\# Old Style

.NETをインストールできない制限された環境でなんとかC\#を利用する場合の話。

## Dependency

- C\#コンパイラ（csc.exe） デフォルトでインストール済みのもの

アプリをインストールできない環境の場合、Windows 10にデフォルトでインストールされているC\#コンパイラを利用する。
テキストエディタもインストールできないので非常に辛いが、コンパイラさえあれば、最悪メモ帳でもプログラミングすることはできる。

## Setup

### C\#コンパイラ（csc.exe）を環境変数に通す

Windows10にはデフォルトで「.NET Framework」がインストールされている。

「.NET Framework」にはC\#コンパイラ（csc.exe）・VBコンパイラ（vbc.exe）が含まれており、Windows Updateなどで「.NET Framework」を更新すると同時にコンパイラも更新される。

厳密にいうと、元のフォルダとは異なるフォルダへのインストールとなるので、最新版の「.NET Framework」フォルダを環境変数に追加し、コマンドプロンプトでcsc.exeを実行できるようにする。

ちなみに2021/08/13(Fri)現在のWindows10 20H2環境には、以下の「.NET Framework」とコンパイラがインストールされていた。

```shell
c:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe
c:\Windows\Microsoft.NET\Framework\v3.5\csc.exe
c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe
c:\Windows\Microsoft.NET\Framework64\v2.0.50727\csc.exe
c:\Windows\Microsoft.NET\Framework64\v3.5\csc.exe
c:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe
```

この環境の場合、32bit版と64bit版があるので、64bit版の最新フォルダである `c:\Windows\Microsoft.NET\Framework64\v4.0.30319` を環境変数に追加する。

### Reference

1. ナガノ, C\# コンパイラ (csc.exe) の使い方, かいてい.net, -, <http://kaitei.net/csharp/csc/>
1. Bill Wagner / olprod / OpenLocalizationService / Saisang Cai, C\# コンパイラ オプション, .NET - C\#ガイド - 言語リファレンス, 2021/03/12
,  <https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/compiler-options/>
1. @toshirot, Visual Studioではなく、Windows付属のcsc.exe だけでC\#実行ファイルを作る, Qiita, 2013/03/28, <https://qiita.com/toshirot/items/dcf7809007730d835cfc>
