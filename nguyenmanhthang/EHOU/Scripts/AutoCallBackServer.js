function heartBeat() {
    $.get("KeepAlive.ashx?", function (data) { });
}
$(function () {
    setInterval("heartBeat()", 1000 * 30); // 30s gửi request một lần
});