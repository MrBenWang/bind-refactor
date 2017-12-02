function get_postition() {
    var _rd_n = Math.floor(Math.random() * $('a').length);
    var _random_a = $($('a')[_rd_n]);
    _random_a.attr('target', '_blank');

    var singleModel = { 'title': '', 'target': '', 'link': '', 'is_ad': false, 'top': 0, 'left': 0 };
    singleModel.title = _rd_n;
    singleModel.link = _random_a.attr('href');
    singleModel.top = parseInt(_random_a.position().top);
    singleModel.left = parseInt(_random_a.position().left);
    return singleModel;
}
get_postition();
_random_a[0].click();