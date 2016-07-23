/**
*
*
*
* 扩展说明：
*  1、
*
*
*/
(function ($) {
    $.extend($.fn.dialog.defaults, {
        url: '',
        width: 750,
        height: 500,
        collapsible: false,
        minimizable: false,
        maximizable: true,
        closable: true,
        tools: [{
            iconCls: 'icon-pop',
            title: '新窗口打开',
            handler: function () {
                var dialogView = $(this).parent().parent().parent().find('.panel-body');
                var url = dialogView.dialog('options').url;
                url += (url.indexOf('?') < 0) ? '?' : '&';
                url += 'isBrowserNewTab=true';
                window.open(".." + url);
                dialogView.dialog('close');
            }
        }],
        onClose: function () {
            $(this).parent().next().remove();
            $(this).parent().remove();
            $("#dialogshadeDiv").removeClass("shade-show");
            $("#dialogshadeDiv").addClass("shade-hide");
        },
        onOpen: function () {
            $('<div id="dialogshadeDiv"></div>').appendTo($(this).parent().parent());
            $("#dialogshadeDiv").removeClass("shade-hide");
            $("#dialogshadeDiv").addClass("shade-show");
        }
    });
})(jQuery);