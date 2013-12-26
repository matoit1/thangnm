var chat_isGetting = false;

function chatSetup() {
    $.ajaxSetup({ timeout: 15000, type: "POST", contentType: "application/json; charset=utf-8", dataType: 'json' });

    chat_getData();
    window.setInterval("chat_getData()", 1000);

    $("#message,#send").keypress(function (event) {
        if (event.keyCode == '13') {
            event.preventDefault();
            chat_sendData();
        }
    });
    $("#send").click(chat_sendData);
}

function chat_sendData() {
    var message = $("#message")[0].value;
    if (message.length > 0) {
        $("#message")[0].value = "";
        $.ajax(
            { cache: false, contentType: "application/json; charset=utf-8", dataType: 'json',
                url: 'chat.aspx/SendUpdate',
                data: '{ConversationId:' + $("#ConversationId")[0].value + ',update:' + JSON.stringify(message) + '}',
                success: chat_getData,
                error: function (XMLHttpRequest, status) {
                    $('#result').append("<div class='errorMessage' />").children(":last").text("Error occurred while trying to send message: " + message);
                    try {
                        var error = $.parseJSON(XMLHttpRequest.responseText).Message;
                        $('#result').append("<div class='errorDetail' />").children(":last").text(error);
                    } catch (ex) {
                        $('#result').append("<div class='errorDetail' />").children(":last").text(XMLHttpRequest.responseText);
                    }
                }
            }
        );
    }
    if (event.srcElement.id == "send")
        $("#message").focus();
}
function chat_getData() {
    if (chat_isGetting) {
        return;
    }

    chat_isGetting = true;
    $.ajax(
            { cache: false, dataType: 'json', contentType: "application/json; charset=utf-8",

                url: 'chat.aspx/GetUpdates',
                data: '{ConversationId:' + $("#ConversationId")[0].value + ',LastUpdateId:' + $("#LastUpdateId")[0].value + '}',
                success: chat_populateItems,
                error: function () { chat_isGetting = false; }
            }
        );
}

//uses IMailUpdate items
function chat_populateItems(data) {
    for (var index = 0; index < data.d.length; index++) {
        var item = data.d[index];
        if ($('#update' + item.UpdateId).length == 0) {
            var text = "(" + item.DateString + ") " + item.Author + ": " + item.Message;
            $('#result').append("<div id='update" + item.Id + "' class='" + item.CssClass + "' />").children(":last").text(text);
        }
    }
    if (data.d.length > 0) {
        $("#LastUpdateId")[0].value = data.d[data.d.length - 1].Id;
        var div = $('#result')[0];
        div.scrollTop = div.scrollHeight;
    }
    chat_isGetting = false;
}