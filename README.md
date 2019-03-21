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

## 構造に関するパターン
### Adapter
- 提供済みのクラス、古いクラス、もろもろの理由でクライアント（クラスの利用者）から隠したいときに使う
- 提供済みのクラス(Adaptee)と、クライアントから利用したいインターフェース(Target)の間にクラス(Adapter)を置くことでAdapteeをラップする
- 継承による実装と、委譲による実装がある
- 継承による実装
  - AdapterクラスがAdapteeクラスを継承し、Targetインターフェースを実装する
- 委譲による実装
  - Adapterクラスの内部でAdapteeクラスのオブジェクトを保持する
  - 多重継承できない場合はオブジェクトに処理を任せてやることで、ラップしている
    - Targetインターフェースがクラスの時とか
	- ラップしたいAdapteeクラスが複数ある時とか
  - こっちのほうが使いやすそう？


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

### TemplateMethod
- ロジック、アルゴリズム、処理の流れの共通化ができる
- 処理の内容の具体的な方法はサブクラスに分離できる
  - 例えば、ファイルに書き込み処理をしたいとき、
  - スーパークラスに Open(), Print(), Close()の順に処理するということを記述する
  - テキストファイルに書き込めるようにしたいなら、サブクラスにOpen(), Print(), Close()にテキストファイルを操作する内容を記述
  - Excleファイルに書き込めるようにしたいなら、サブクラスにOpen(), Print(), Close()にExcelファイルを操作する内容を記述
- インターではなく