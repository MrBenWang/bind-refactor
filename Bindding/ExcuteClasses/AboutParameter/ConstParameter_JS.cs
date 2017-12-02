using System;

namespace Bindding.ExcuteClasses
{
    /// <summary>
    /// js 的常量
    /// </summary>
    internal static partial class ConstParameter
    {
        #region 百度

        /// <summary>
        /// 百度 模拟点击的js
        /// </summary>
        internal static string GET_BAIDU_LIST_JS =
            @"'; function getBaiduContentList() {
    if ($('div.nums').text()) {
        var _retlist = [];
        var _title = '';
        $('#head').hide();
        $('#content_left div h3 a').each(function (index, el) {
            var singleModel = { 'title': '', 'target': '', 'link': '', 'is_ad': false, 'top': 0, 'left': 0 };
            var _element = $(el);
            singleModel.title = _element.text();
            singleModel.link = _element.attr('href');
            singleModel.top = parseInt(_element.position().top);
            singleModel.left = parseInt(_element.position().left);
            if (_element.attr('data-landurl')) {
                if (_element.attr('data-landurl').indexOf(_matchKey) > -1) {
                    singleModel.is_ad = true;
                    singleModel.target = _element.attr('data-landurl');
                    _retlist.push(singleModel);
                }
            } else {
                var _tmptitle = $('a[href=\'' + _element.attr('href') + '\'][class=\'c-showurl\']').text();
                if (_tmptitle.indexOf(_matchKey) > -1) {
                    singleModel.is_ad = false;
                    singleModel.target = _tmptitle;
                    _retlist.push(singleModel);
                }
            }
        });

        return JSON.stringify(_retlist);
    }

    return [];
}

getBaiduContentList();".Replace(Environment.NewLine, string.Empty);

        #endregion 百度

        #region 随机浏览的js

        /// <summary>
        /// 获取弹出页面的随机一个a标签
        /// </summary>
        internal static string GET_POPUP_RANDOM_A = @"
function get_postition() {
    var _rd_n = Math.floor(Math.random() * $('a[href!=#][target=_blank]').length);
    var _random_a = $($('a[href!=#][target=_blank]')[_rd_n]);

    var singleModel = { 'title': '', 'target': '', 'link': '', 'is_ad': false, 'top': 0, 'left': 0 };
    singleModel.title = _rd_n;
    singleModel.link = _random_a.attr('href');
    singleModel.top = parseInt(_random_a.position().top);
    singleModel.left = parseInt(_random_a.position().left);
    return JSON.stringify(singleModel);
}

get_postition();".Replace(Environment.NewLine, string.Empty);

        internal static string GET_POPUP_CLICK_A = @";$('a[href!=#][target=_blank]')[_n].click();";

        #endregion 随机浏览的js
    }
}