# CSharp-DesignPatterns
C#でデザインパターン学習

有用そうなのから、順に書いていきます

## デザインパターンとは
プログラムの設計において、定石となる手法をパターン化したものです。有名なものにGoFの23パターンがある。

GoFのパターンは20年以上前のものだし、言語レベルで実装済みのものもあるけど、OOPを理解するには知っておいてもいい？

あくまで、有用そうなのをパターン化しただけです。

## デザインパターンの種別
- 生成に関するパターン
- 構造に関するパターン
- 振る舞いに関するパターン

## 生成に関するパターン
### FactoryMethod
### AbstractFactory
### Builder
### Singleton

## 振る舞いに関するパターン
### Iterator
- オブジェクトの集合の内部構造に依存しないインターフェースを提供できる
- オブジェクトの追加、取得（内部構造）と、順次アクセス（走査）を分離できる
- 集合体AggregateをIteratorインターフェースで順次アクセスしていくイメージ
C#ではベースクラスライブラリに追加されている

|Iteratorパターン|C#|
|:--|:--|
|Aggregateインターフェース|IEnumerable|
|Iteratorインターフェース|IEnumrator|

C#ではIEnumerableを実装しておくと自作のコレクションクラスをforeachでループ可能になる

```csharp
// この構文と
var iterator = bookShelf.GetEnumerator();
while (iterator.MoveNext())
{
	Console.Write(iterator.Current);
}

// この構文は同じことをしている
// iteratorの生成、MoveNext()による次の値への移動、Currentによる値の取得が省略できる
foreach(var book in bookShelf)
{
	Console.WriteLine(book.Name);
}
```