'use strict';

// List操作のために必要なオブジェクト取得に使う変数
var clientContext;
var employeeList;
var myItems;
var notStartedItems;

// まずSharepointの基盤となるsp.jsをロードした上に、初期化ファンクション（SharePointReady）を呼び出す
SP.SOD.executeFunc('sp.js', 'SP.ClientContext', sharePointReady);



var siteUrl = '/sites/MySiteCollection';

// 打刻成功
function onQuerySucceeded() {

    alert('打刻しました。');
}

// 打刻失敗
function onQueryFailed() {

    
}

// 出勤打刻ファンクション
function clockinDaily() {

    
    // 日報List取得
    var oList = clientContext.get_web().get_lists().getByTitle('Daily Reports');

    var d = new Date();
    var itemCreateInfo = new SP.ListItemCreationInformation();
    var oListItem = oList.addItem(itemCreateInfo);

    // 各種入力値設定
    oListItem.set_item('Reporter', _spPageContextInfo.userId );
    oListItem.set_item('WorkDate', d);
    oListItem.set_item('InMinute', (d.getHours() * 60 + d.getMinutes()) );


    // レコード更新後、非同期でListに更新をかける
    oListItem.update();
    clientContext.load(oListItem);
    clientContext.executeQueryAsync(onQuerySucceeded, onQueryFailed);
}

// 退勤打刻ファンクション
function clockoutDaily() {

    var camlQuery = new SP.CamlQuery();
    var d = new Date();
    var todayDate = getDateStr(d);
    
    // CAMLクエリで本日のレコード、かつ自分のUserIDで登録されているレコードをGET
    var camlXML = "<View><Query><Where><And><Eq><FieldRef Name='Reporter' LookupId='True'/><Value Type='Lookup'>" + _spPageContextInfo.userId + "</Value></Eq><And><Geq><FieldRef Name='WorkDate'/><Value Type='DateTime'>" + todayDate + " 00:00:00</Value></Geq><Leq><FieldRef Name='WorkDate'/><Value Type='DateTime'>" + todayDate + " 23:59:59</Value></Leq></And></And></Where></Query></View>";

    // DefaultページのASP.NETフォームから入力値を取得し、セット
    var outComment = $("textarea[id$=commentbox]").val();
    var outBreak = parseInt($("input[id$=breaktimebox]").val());
    var outSentiment = $("select[id$=sentiment]").val();
    
    // 入力値バリデーション
    if (outComment.length < 20) {
        alert("感想は10文字以上で入力してください");
        return false;
    }

    if (isNaN(outBreak)) {
        alert("休憩時間は正しい数字（分）で入力してください")
        return false;
    }

    camlQuery.set_viewXml(camlXML);
    myItems = employeeList.getItems(camlQuery);

    clientContext.load(myItems);
    clientContext.executeQueryAsync(function () {
    var enumerator = myItems.getEnumerator();
    var itemCount = myItems.get_count();

        // 取得したレコードセットに対して退勤時間・コメントその他値を更新
        // 本来はこの日のレコードは１件のみのはずだが、全部に対して順に更新している
    while (enumerator.moveNext()) {
        var item = enumerator.get_current();
        item.set_item('OutMinute', (d.getHours()*60 + d.getMinutes()));
        item.set_item('BreakMinute',outBreak);
        item.set_item('Comment',outComment);
        item.set_item('Sentiment',outSentiment);
        item.update();
        clientContext.load(item);
        clientContext.executeQueryAsync(onQuerySucceeded, onQueryFailed);
    }


       
    },
    // クエリ失敗の場合
      function (s, a) {
       alert("NOTHING FOUND");
      });
    // 最後にページをリロード
   window.location.reload();
}


// Utility functions

function getQueryStringParameter(paramToRetrieve) {
    var params = document.URL.split("?")[1].split("&");
    var strParams = "";
    for (var i = 0; i < params.length; i = i + 1) {
        var singleParam = params[i].split("=");
        if (singleParam[0] == paramToRetrieve) {
            return singleParam[1];
        }
    }
}

// DateTime型をもらって、日付のStringにして返す
function getDateStr(dateParam) {

    var dd = dateParam.getDate();
    var mm = dateParam.getMonth() + 1; //January is 0!

    var yyyy = dateParam.getFullYear();
    if (dd < 10) {
        dd = '0' + dd
    }
    if (mm < 10) {
        mm = '0' + mm
    }
    var returnDateStr = yyyy + '-' + mm + '-' + dd;
    return returnDateStr;
}

// 00:00から何分経ったかの数字をもらって、時刻のStringにして返す
function getTimeStr(minuteParam) {

    var hhh = Math.floor(minuteParam / 60);
    var mmm = minuteParam % 60;
    var returnTimeStr = "";
    
    if (hhh < 10) {
       returnTimeStr += '0'
    }
    returnTimeStr += hhh.toString() + ":";
    if (mmm < 10) {
        returnTimeStr += '0'
    }
    returnTimeStr += mmm.toString();

    return returnTimeStr;
}

// 初期化ファンクション。ページをロードするとまず動く
// 日報の表を更新したり、ボタンを有効か無効かしたりする
function sharePointReady() {

    // まずクロックアウトは無効化しておく
    $("#clockoutbutton").prop('disabled', true);

    clientContext = SP.ClientContext.get_current();
    employeeList = clientContext.get_web().get_lists().getByTitle('Daily Reports');

    var camlXML;
    var iDate;
    var camlQuery = new SP.CamlQuery();

    var d = new Date();
    var startDate = new Date(d.getTime() - 6 * 24 * 60 * 60 * 1000);

    var todayDate = getDateStr(d);
    var dateStr = getDateStr(startDate);

    var dateArray = new Array(8);

    // 直近7日間の日付をdateArrayの配列に格納しつつ、表に更新
    // 土曜日なら青色、日曜日なら赤色に設定し、jQueryでdivを更新していく
    for (var i = 1 ; i <= 7 ; i++) {
        
        iDate = new Date(d.getTime() - ((7-i)  * 24 * 60 * 60 * 1000));
        dateArray[i] = getDateStr(iDate);
        var colorStr;
        if (iDate.getDay() == 0) {
            colorStr = "<font color='red'>";
        }
        else if (iDate.getDay() == 6) {
            colorStr = "<font color='blue'>";
        }
        else {
            colorStr = "<font color='black'>";
        }
        $("#reportDate" + i).html(colorStr + dateArray[i] + "</font>");

       }
    
    // 直近7日間の日報レコードを取得するCAMLクエリ
    camlXML = "<View><Query><Where><And><Eq><FieldRef Name='Reporter' LookupId='True'/><Value Type='Lookup'>" + _spPageContextInfo.userId + "</Value></Eq><And><Geq><FieldRef Name='WorkDate'/><Value Type='DateTime'>" + dateStr + " 00:00:00</Value></Geq><Leq><FieldRef Name='WorkDate'/><Value Type='DateTime'>" + todayDate + " 23:59:59</Value></Leq></And></And></Where></Query></View>";
        
        camlQuery.set_viewXml(camlXML);

        myItems = employeeList.getItems(camlQuery);

        clientContext.load(myItems);
        
        clientContext.executeQueryAsync(function () {
            var enumerator = myItems.getEnumerator();
            var itemCount = myItems.get_count();

            var itemWorkDate;
            var itemInMinute;
            var itemOutMinute;
            var itemBreakMinute;
            var itemWorkHour;
            var itemComment;
            var itemSentiment;

            var commentStr;


            // レコードを順になめながら表に更新していく
            if (itemCount > 0) {
                while (enumerator.moveNext()) {


                    itemWorkDate = enumerator.get_current().get_item('WorkDate');
                    itemInMinute = enumerator.get_current().get_item('InMinute');
                    itemBreakMinute = enumerator.get_current().get_item('BreakMinute');
                    itemOutMinute = enumerator.get_current().get_item('OutMinute');

                    itemComment = enumerator.get_current().get_item('Comment');
                    itemSentiment = enumerator.get_current().get_item('Sentiment');

                    // 配列の日付と比較し、表のどの行に表示するか決める
                    for (var i = 1 ; i <= 7 ; i++) {
                        if (getDateStr(itemWorkDate) == dateArray[i]) {


                            if (itemComment) {
                                commentStr = itemComment.toString().substring(0, 16) + "..";
                                $("#reportComment" + i).html(commentStr);
                            }

                            if (itemInMinute) {
                                $("#reportClockIn" + i).html(getTimeStr(itemInMinute));
                            }

                            if (itemOutMinute) {
                                $("#reportClockOut" + i).html(getTimeStr(itemOutMinute));
                            }

                            if ((itemInMinute) && (itemOutMinute)) {
                                itemWorkHour = Math.floor(((itemOutMinute - itemInMinute - itemBreakMinute) / 60 * 100)) / 100;
                                if (itemWorkHour < 0) {
                                    itemWorkHour = 0;
                                }
                                $("#reportWorkTime" + i).html(itemWorkHour);
                            }

                            if (itemBreakMinute) {
                                $("#reportBreakTime" + i).html(itemBreakMinute);
                            }

                            if (itemSentiment) {
                                $("#reportSentiment" + i).html(itemSentiment);
                            }

                            // 本日の日報がある場合、クロックインしているか、クロックアウトしているかを確認し
                            // それに合わせて打刻ボタンを有効化したり無効化する
                            if (i == 7) {
                                if (itemInMinute) {
                                    $("#clockinbutton").prop('disabled', true);
                                    if (!itemOutMinute) {
                                        $("#clockoutbutton").prop('disabled', false);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        },
    　　// クエリ失敗の場合
        function (s, a) {
            alert("ERROR retrieving daily report" + a.get_message() + a.get_stackTrace());
        });
}
