/**
*
*
*
* 扩展说明：
*  1、promptDate
*
*
*/
(function ($) {

    $.extend($.messager, {
        promptDate: function (title, msg, value, fn) {
            var content = '<div class="messager-icon messager-question"></div>'
                        + '<div>' + msg + '</div>'
                        + '<br/>'
                        + '<input id="promptDate" type="text" style="width:265px" value="' + value + '" />'
                        + '<div style="clear:both;"/>';
            var buttons = {};
            buttons[$.messager.defaults.ok] = function () {
                win.window('close');
                if (fn) {
                    fn("ok", $('#promptDate', win).datebox('getValue'));
                    return false;
                }
            };
            buttons[$.messager.defaults.cancel] = function () {
                win.window('close');
                if (fn) {
                    fn("cancel");
                    return false;
                }
            };
            var win = createMessageDialog(title, content, buttons);
        },
        promptDate2: function (title, msg, chkboxText, value, checked, fn) {
            var content = '<div class="messager-icon messager-question"></div>'
                        + '<div>' + msg + '</div>'
                        + '<br/>'
                        + '<input id="promptDate" type="text" style="width:265px" value="' + value + '" />'
                        + '<br/>'
                        + '<input type="checkbox" id="chkBox"';
            if (checked) {
                content += ' checked="true" ';
            }
            content += ' style="vertical-align:middle;width:18px;margin-left:30px;" />'
                        + '<label style="text-align:left;width:200px" for="chkBox">' + chkboxText + '</label>'
                        + '<div style="clear:both;"/>';
            var buttons = {};
            buttons[$.messager.defaults.ok] = function () {
                win.window('close');
                if (fn) {
                    fn('ok', $('#promptDate', win).datebox('getValue'), $('#chkBox', win)[0].checked);
                    return false;
                }
            };
            buttons[$.messager.defaults.cancel] = function () {
                win.window('close');
                if (fn) {
                    fn('cancel');
                    return false;
                }
            };
            var win = createMessageDialog(title, content, buttons);
        },
        promptComboBox: function (title, msg, options, fn) {

            options = $.extend({ url: '', value: '', panelHeight: 200 }, options || {});

            var content = '<div class="messager-icon messager-question"></div>'
                        + '<div>' + msg + '</div>'
                        + '<br/>'
                        + '<input class="easyui-combobox" id="promptComboBox" panelHeight="' + options.panelHeight + '" value="' + options.value + '" style="width:265px" url=\'' + options.url + '\'>'
                        + '<div style="clear:both;"/>';
            var buttons = {};
            buttons[$.messager.defaults.ok] = function () {
                win.window('close');
                if (fn) {
                    fn("ok", $('#promptComboBox', win).combobox('getValue'));
                    return false;
                }
            };
            buttons[$.messager.defaults.cancel] = function () {
                win.window('close');
                if (fn) {
                    fn("cancel");
                    return false;
                }
            };
            var win = createMessageDialog(title, content, buttons);
        }
    });

    function createMessageDialog(title, content, buttons) {
        var win = $('<div class="messager-body"></div>').appendTo('body');
        win.append(content);
        if (buttons) {
            var tb = $('<div class="messager-button"></div>').appendTo(win);
            for (var label in buttons) {
                $('<a></a>').attr('href', 'javascript:void(0)').text(label)
                        .css('margin-left', 10)
                        .bind('click', eval(buttons[label]))
                        .appendTo(tb).linkbutton();
            }
        }
        win.window({
            title: title,
            width: 300,
            height: 'auto',
            modal: true,
            collapsible: false,
            minimizable: false,
            maximizable: false,
            resizable: false,
            onClose: function () {
                setTimeout(function () {
                    win.window('destroy');
                }, 100);
            }
        });
        $("#promptDate", win).datebox();
        var url = $("#promptComboBox").attr('url');
        $("#promptComboBox", win).combobox({
            url: url,
            valueField: 'value',
            textField: 'text'
        });
        return win;
    }
})(jQuery);
