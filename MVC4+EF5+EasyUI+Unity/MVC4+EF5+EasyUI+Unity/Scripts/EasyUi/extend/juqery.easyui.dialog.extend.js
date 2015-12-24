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
                var dialogView = $(this.parentElement.parentElement.parentElement).find('.panel-body');
                var toobalHtml = dialogView.parent().find('.dialog-toolbar');
                //希望新的选项卡中带有这个button
                console.log(toobalHtml);
                window.open(dialogView.dialog('options').url);
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