★使用アセット
	UniRx
	UniTask
	DotWeen

★外部素材(クレジット用)

★備考
	URP導入済み

★確認済みの不具合
	手札のカードを高速で連続クリックすると場にカードが2枚重なってしまう。
		場に出ているカードは1枚として認識されている。
		他の手札のカードをクリックすることで戻る。

●谷村君タスク
	ButtleJudge <= バトルの綴りはBattleだから直してほしい。

	タイトル画面の作成
	フェードの作成
	タイトル画面


	フェードに関してはタイトルとゲームシーンで使いまわすのでシングルトンでの実装がおすすめ
		フェードインのメソッド、フェードアウトのメソッドを作る
	タイトル画面はボタンを押したらポップが出る、ボタンを押したらフェードしてゲームシーンに遷移する、
		ボタンを押したらゲームが終了する、の3つの機能があれば良い。

★ 予定
	ゲーム開始、ゲーム終了演出の作成
★ 処理済み
	Player1WinCount()メソッドじゃなくてPlayer1Count()メソッドのほうが良いと思う。
		メソッドの中身もPlayer1Count()を呼んだらPlayer1が、Player2Count()を呼んだらPlayer2が
		更新されてほしい。
	名前もSetPlayer1Count()とかにして値をセットする事がわかる名前だと使うときにうれしい。
	GetComponentはStart()で1回だけ行ってキャッシュするやり方が良いので直しておいてほしい。
	メソッドとメソッドの間は1行開けてほしい。
	メソッドの実引数は最初に_を付けないから消してほしい。
	Start()とUpdate()のコメントは消して問題なし。
	メソッドに書くコメントは横じゃなくて上の方が良い。

	勝敗を判定するメソッドの制作
	カードにはそのカードの数字(1~9,/)が割り振られているからそれで判定する。
	カードの効果に関してはメソッド内で処理できるものはしてほしい。
	出来ないものはコメントで残しておいてほしい。

	//イメージとしてはこんな感じ、引数は増やしても大丈夫。戻り値は勝った方のプレイヤーを返してほしい。
	int Battle(Card card1, Card card2)
	{
		//処理

		// 勝者を返す、Player1なら1、Player2なら2を返す。
		return 1;
	}