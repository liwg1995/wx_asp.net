(function(window, $) {
    $(function() {

        setTimeout(function() {
            window.scrollTo(0, 1)
        }, 0);
        document.addEventListener("touchstart", function() {
            return false;
        }, true);


        $('body').click(function(e) {
            var target = $(e.target),
				node = $('#downList');
            if (target.closest('.ui-qnav').hasClass('ui-qnav') && node.get(0).style.display === 'none') {
                node.show();
            }
            else {
                node.hide();
            }
        });
    });

    if ($('.listdl,.detaildl').find('dd').find('a:first').text('')) {
        $('.listdl,.detaildl').find('dd').find('a:first').remove();
    }

    $('.more-icon').on('click', function() {
        var oNumber = $(this).attr('attrNum');
        if (oNumber == 2) {
            $(this).prev('dl').addClass('h60')
            $(this).prev('dl').find('dd').addClass('text-elli3');
            $(this).find('span').removeClass('update').addClass('more');
            $(this).attr({ 'attrNum': '1' });
        }
        if (oNumber == 1) {
            $(this).prev('dl').removeClass('h60')
            $(this).prev('dl').find('dd').removeClass('text-elli3');
            $(this).find('span').removeClass('more').addClass('update');
            $(this).attr({ 'attrNum': '2' });
        }
    });


})(window, jQuery);