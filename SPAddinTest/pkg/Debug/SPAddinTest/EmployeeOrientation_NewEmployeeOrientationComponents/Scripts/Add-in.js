'use strict';

var clientContext;
var employeeList;
var myItems;
var notStartedItems;
var calendarList;
var scheduledItems;
var hostWebURL;
//var hostWebURL = decodeURIComponent(getQueryStringParameter("SPHostUrl"));

var clockedIn;
var clockedOut;

SP.SOD.executeFunc('sp.js', 'SP.ClientContext', sharePointReady);

// クロックイン

var siteUrl = '/sites/MySiteCollection';


function onQuerySucceeded() {

    alert('打刻しました。');
}

function onQueryFailed() {

    
}

function clockinDaily() {

    

    var oList = clientContext.get_web().get_lists().getByTitle('Daily Reports');
    var d = new Date();
    var itemCreateInfo = new SP.ListItemCreationInformation();
    var oListItem = oList.addItem(itemCreateInfo);

    oListItem.set_item('Reporter', _spPageContextInfo.userId );
    oListItem.set_item('WorkDate', d);
    oListItem.set_item('InMinute', (d.getHours() * 60 + d.getMinutes()) );

    oListItem.update();

    clientContext.load(oListItem);

    clientContext.executeQueryAsync(onQuerySucceeded, onQueryFailed);
}

function clockoutDaily() {

    var camlQuery = new SP.CamlQuery();
    var d = new Date();
    var todayDate = getDateStr(d);
    
    var camlXML = "<View><Query><Where><And><Eq><FieldRef Name='Reporter' LookupId='True'/><Value Type='Lookup'>" + _spPageContextInfo.userId + "</Value></Eq><And><Geq><FieldRef Name='WorkDate'/><Value Type='DateTime'>" + todayDate + " 00:00:00</Value></Geq><Leq><FieldRef Name='WorkDate'/><Value Type='DateTime'>" + todayDate + " 23:59:59</Value></Leq></And></And></Where></Query></View>";

    var outComment = $("textarea[id$=commentbox]").val();
    var outBreak = parseInt($("input[id$=breaktimebox]").val());
    var outSentiment = $("select[id$=sentiment]").val();
    

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


   //         var comment = $("#commentbox").val();
//
  //          alert(comment);

    //        item.set_item('ClockOutTime', d);
      //      item.set_item('Comment', comment)
      //          item.update();
      //          clientContext.load(item);
      //          clientContext.executeQueryAsync(onQuerySucceeded, onQueryFailed);
                
      //      }
            
        
        
        

       
    },
      function (s, a) {
       alert("NOTHING FOUND");
     });
   window.location.reload();
}




   // var camlQuery = new SP.CamlQuery();
  //  var camlXML = "<View><Query><Where><Eq><FieldRef Name='Reporter' LookupId='True'/><Value Type='Lookup'>" + _spPageContextInfo.userId + "</Value></Eq></Where></Query></View>";

//    camlQuery.set_viewXml(camlXML);
//    myItems = employeeList.getItems(camlQuery);
 //   clientContext.load(myItems);

 //   clientContext.executeQueryAsync(function () {
  //      var enumerator = myItems.getEnumerator();
   //     while (enumerator.moveNext()) {
     //           var item = enumerator.get_current().get_item('ClockInTime');
    //            alert("Clock-in time is " + item);
    //        }
       
  //  },
     //   function (s, a) {
       //     alert("NOTHING FOUND");
   //     });

    


function deleteCompletedItems() {

    var itemArray = new Array();
    var listItemEnumerator = completedItems.getEnumerator();

    while (listItemEnumerator.moveNext()) {
        var item = listItemEnumerator.get_current();
        itemArray.push(item);
    }

    var i;
    for (i = 0; i < itemArray.length; i++) {
        employeeList.getItemById(itemArray[i].get_id()).deleteObject();
    }

    clientContext.executeQueryAsync(onDeleteCompletedItemsSuccess, onDeleteCompletedItemsFail);
}

function onDeleteCompletedItemsSuccess() {
    alert('Completed orientations have been deleted.');
    location.reload(true);
}

function ensureOrientationScheduling() {

    var camlQuery = new SP.CamlQuery();
    camlQuery.set_viewXml(
        '<View><Query><Where><Eq>' +
            '<FieldRef Name=\'OrientationStage\'/><Value Type=\'Choice\'>Not started</Value>' +
        '</Eq></Where></Query></View>');
    notStartedItems = employeeList.getItems(camlQuery);

    clientContext.load(notStartedItems);
    clientContext.executeQueryAsync(getScheduledOrientations, onGetNotStartedItemsFail);
    return false;
}

function getScheduledOrientations() {

    var hostWebContext = new SP.AppContextSite(clientContext, hostWebURL);
    calendarList = hostWebContext.get_web().get_lists().getByTitle('Employee Orientation Schedule');

    var camlQuery = new SP.CamlQuery();
    scheduledItems = calendarList.getItems(camlQuery);

    clientContext.load(scheduledItems);
    clientContext.executeQueryAsync(scheduleAsNeeded, onGetScheduledItemsFail);
}

function scheduleAsNeeded() {

    var unscheduledItems = false;
    var dayOfMonth = '10';

    var listItemEnumerator = notStartedItems.getEnumerator();

    while (listItemEnumerator.moveNext()) {
        var alreadyScheduled = false;
        var notStartedItem = listItemEnumerator.get_current();

        var calendarEventEnumerator = scheduledItems.getEnumerator();
        while (calendarEventEnumerator.moveNext()) {
            var scheduledEvent = calendarEventEnumerator.get_current();

            // The SP.ListItem.get_item('field_name') method gets the value of the specified field.
            if (scheduledEvent.get_item('Title').indexOf(notStartedItem.get_item('Title')) > -1) {
                alreadyScheduled = true;
                break;
            }
        }
        if (alreadyScheduled === false) {

            // SP.ListItemCreationInformation holds the information the SharePoint server needs to
            // create a list item
            var calendarItem = new SP.ListItemCreationInformation();

            // The some_list.additem method tells the server which list to add 
            // the item to.
            var itemToCreate = calendarList.addItem(calendarItem);

            // The some_item.set_item method sets the value of the specified field.
            itemToCreate.set_item('Title', 'Orient ' + notStartedItem.get_item('Title'));

            // The EventDate and EndDate are the start and stop times of an event.
            itemToCreate.set_item('EventDate', '2016-10-' + dayOfMonth + 'T21:00:00Z');
            itemToCreate.set_item('EndDate', '2016-10-' + dayOfMonth + 'T23:00:00Z');
            dayOfMonth++;

            // The update method tells the server to commit the changes to the SharePoint database.
            itemToCreate.update();
            unscheduledItems = true;
        }
    }
    if (unscheduledItems) {
        calendarList.update();
        clientContext.executeQueryAsync(onScheduleItemsSuccess, onScheduleItemsFail);
    }
}

function onScheduleItemsSuccess() {
    alert('There was one or more unscheduled orientations and they have been added to the '
              + 'Employee Orientation Schedule calendar.');
}

function onGetNotStartedItemsFail(sender, args) {
    alert('Unable to get the not-started items. Error:'
        + args.get_message() + '\n' + args.get_stackTrace());
}

function onGetScheduledItemsFail(sender, args) {
    alert('Unable to get scheduled items from host web. Error:'
        + args.get_message() + '\n' + args.get_stackTrace());
}

function onScheduleItemsFail(sender, args) {
    alert('Unable to schedule items on host web calendar. Error:'
        + args.get_message() + '\n' + args.get_stackTrace());
}

// Failure callbacks

function onGetCompletedItemsFail(sender, args) {
    alert('Unable to get completed items. Error:' + args.get_message() + '\n' + args.get_stackTrace());
}

function onDeleteCompletedItemsFail(sender, args) {
    alert('Unable to delete completed items. Error:' + args.get_message() + '\n' + args.get_stackTrace());
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


function sharePointReady() {


    $("#clockoutbutton").prop('disabled', true);

    clockedIn = false;
    clockedOut = false;

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
            


            if (itemCount > 0) {
                while (enumerator.moveNext()) {

            
                    itemWorkDate = enumerator.get_current().get_item('WorkDate');
                    itemInMinute = enumerator.get_current().get_item('InMinute');
                    itemBreakMinute = enumerator.get_current().get_item('BreakMinute');
                    itemOutMinute = enumerator.get_current().get_item('OutMinute');

                    

                    itemComment = enumerator.get_current().get_item('Comment');
                    itemSentiment = enumerator.get_current().get_item('Sentiment');

                    
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

                            if (i==7) {
                                if (itemInMinute) {
                                    $("#clockinbutton").prop('disabled', true);
                                    if (!itemOutMinute) {
                                        $("#clockoutbutton").prop('disabled', false);
                                    }
              //                      $("#clockin").html("<img src='../Images/clockin_inactive.png'>");
                                }
       //                         if (itemOutMinute) {
         //                           $("#clockoutbutton").attr('disabled', 'disabled');
                                  //  html("<img src='../Images/clockout_inactive.png'>");
           //                     }

                            }
                                

                                
                            }
                            

                        }
                    }
                }
            
        },
        function (s, a) {
            alert("ERROR retrieving daily report" + a.get_message() + a.get_stackTrace());
        });

  //  }

    

}
