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
            $("#shadeDiv").remove();
            $('<div id="modalwindow" style="display:none"></div>').appendTo($('#mainTab').tabs("getSelected"));
        },
        onBeforeClose: function () {
            $("#shadeDiv").remove();
        },
        onOpen: function () {
            $('<div id="shadeDiv" style="filter:alpha(opacity=90);position: absolute; z-index: 1000; top: 0px; left: 0px; width: 100%; height: 100%; background: #DDDDDB; text-align: center; padding-top: 20%;"></div>').appendTo($('#mainTab').tabs("getSelected"));
            $("#modalwindow").remove();
        }
    });
})(jQuery);