//閫昏緫灞�
var Mxywy = {
    //棣栧厛寮€濮嬪椤甸潰杩涜鍩烘湰璁剧疆
    basic: function() {
        //鍒ゆ柇pc杩樻槸mobile;
        if (IsPC()) {
            ick = 'click';
        } else {
            ick = 'touchend';
        }
        //妫€鏌c杩樻槸绉诲姩绔�
        function IsPC() {
            var userAgentInfo = navigator.userAgent;
            var Agents = new Array("Android", "iPhone", "SymbianOS", "Windows Phone", "iPad", "iPod");
            var flag = true;
            for (var v = 0; v < Agents.length; v++) {
                if (userAgentInfo.indexOf(Agents[v]) > 0) { flag = false; break; }
            }
            return flag;
        }
        //浠讳綍鐩爣鐐瑰嚮tap璺宠浆(涓嶉噰鐢╟lick浜�)    data-href="baidu.com";        鍥犲弽搴旇繃蹇祴璇曚笉閫氳繃(鐐瑰嚮绌块€�)
        $('[data-href]').on(ick, function() {
            window.location = $(this).attr('data-href');
        });
        //绉诲姩绔痑vtive浼被浜嬩欢
        document.addEventListener("touchstart", function() {
            return false;
        }, true);
    },
    //灏佽濂借烦杞〉闈㈢殑鏂规硶(鏇夸唬A閾炬帴鐨勬柟娉�)锛岀粰鍚庢潵鐢熸垚鐨勫厓绱犳潵浣跨敤
    dataHref: function() {
        //浠讳綍鐩爣鐐瑰嚮tap璺宠浆(涓嶉噰鐢╟lick浜�)       鈫抝s瀵硅薄鏂瑰紡灞曠幇鍦ㄩ〉闈腑鐨勮烦杞摼鎺ヨ烦涓嶄簡锛岄渶瑕佽缃竴涓柟娉� 
        $('[data-href]').on(ick, function() {
            window.location = $(this).attr('data-href');
        });
    },
    //澶村熬寮€濮嬶紒锛侊紒鍏叡澶淬€佸叕鍏卞熬寮€濮嬭繍琛岋紒
    //http://static.css.xywy.com/common/css/3gbx.css
    //http://static.js.xywy.com/common/js/jqueryMin.js
    //http://static.js.xywy.com/common/js/jquery.mobile.custom.min.js
    //The head to deal with
    pate: function inclusio(versions) {
        this.head = '<header><div class="title"><img src="http://static.img.xywy.com/common/images/logo.png"alt="" data-href="http://3g.xywy.com/"/><span data-html="title">瀹跺涵鍖荤敓</span></div><div class="function"><span data-href="http://3g.xywy.com/so"></span><b data-hamburgerList="show"><i></i><i></i><i></i></b></div></header>',
		this.foot = '<footer><p data-simple="obligate"><span class="blue" data-href="http://3g.i.xywy.com/index/login?" data-stats="order">鐧诲綍</span> | <span data-href="http://3g.i.xywy.com/index/register?" class="blue" data-stats="quiz">娉ㄥ唽</span></p><p data-simple="obligate"><span data-href="http://3g.xywy.com/">棣栭〉</span> | <span data-href="http://3g.club.xywy.com/">鏈夐棶蹇呯瓟</span> | <span data-href="http://3g.jib.xywy.com/">鏌ョ柧鐥�</span> | <span data-href="http://3g.yao.xywy.com/">鎵捐嵂鍝�</span> | <span data-href="http://3g.zhuanjia.xywy.com/">鎵句笓瀹�</span></p><p data-simple="pt20"><span class="grey">瑙﹀睆鐗�</span> | <span class="blue"data-href="http://www.xywy.com/?vt=1">鐢佃剳鐗�</span><b data-simple="hide"> | <span class="blue"data-href="http://app.xywy.com/pc/ask.html">APP</span> | <span class="blue"data-href="http://3g.xywy.com/feedback?from=3g_index">鎻愭剰瑙�</span></b></p><h6>鍙傝€冧俊鎭笉浣滀负璇婃柇鍖荤枟鏁版嵁</h6><h6>鐗堟潈鎵€鏈�:瀵诲尰闂嵂(2002-2015)</h6></footer>'
        //鎵ц澶撮儴鍔ㄤ綔
        this.callHead = function(isUser, title, bgColor, account) {
            this.isUser = isUser;
            this.title = title;
            this.bgColor = bgColor;
            this.account = account;
            $('body').prepend(this.head);
            $('[data-html=title]').html(this.title);
            $('header').css('background', this.bgColor);
            if (this.isUser == false) {
                //userCenter
                $('header .title').html('<b data-href="http://3g.xywy.com/">瀵诲尰闂嵂缃懧�</b><span data-href="http://3g.i.xywy.com/user/index">' + this.title + '</span>');
                $('header .title span').css({ 'border-left': 'none', 'margin-left': '0', 'padding-left': '0' });
                $('.function').attr('data-href', 'http://3g.i.xywy.com/index/login?');
                $('.function').html('鐧诲綍');
            }
            //椤跺鍙充晶姹夊牎鍖卛con鍒楄〃娣诲姞浜嬩欢
            $('[data-back=bgGrey]').on('click', function() {
                $('[data-list=hamburger]').animate({
                    'right': '-50%'
                }, 300, function() {
                    $('[data-back=bgGrey]').hide();
                });
            });
            $('[data-hamburgerList=show]').on(ick, function() {
                $('[data-list=hamburger]').animate({
                    'right': '0'
                }, 300, function() {
                    $('[data-back=bgGrey]').show();
                });
            });
            $('[data-hamburger=close]').on('click', function() {
                $('[data-list=hamburger]').animate({
                    'right': '-50%'
                }, 300, function() {
                    $('[data-back=bgGrey]').hide();
                });
            });
            //璁剧疆璺宠浆閾炬帴
            Mxywy.dataHref();
        }
        this.callFoot = function(versions) {
            this.versions = versions;
            //鎵ц灏鹃儴鍔ㄤ綔
            $('body').append(this.foot);
            if (this.versions == 'logIn') {
                $('[data-stats=order]').html('鎴戠殑棰勭害');
                $('[data-stats=quiz]').html('鎴戠殑鎻愰棶');
                $('[data-stats=order],[data-stats=quiz]').attr('data-href', 'http://3g.club.xywy.com/user_center.php');
            } else if (this.versions == 'simple') {
                $('[data-simple=pt20]').css('padding-top', '20px');
                $('[data-simple=obligate],[data-simple=hide]').hide();
            }
            //璁剧疆璺宠浆閾炬帴
            Mxywy.dataHref();
        };
    },
    //琛ㄥ崟鍩烘湰璁剧疆
    webForms: function() {
        //Submission form settings(琛ㄥ崟鍩烘湰璁剧疆)
        //鏀逛负鐐瑰嚮娑堝けplaceholder   
        var placeholder;
        $('[data-ph=hide]').on('focus', function() {
            placeholder = $(this).attr('placeholder');
            $(this).attr('placeholder', '');
        }).on('blur', function() {
            $(this).attr('placeholder', placeholder);
        });
        //鏂囨湰鍩熺洃瑙嗘枃鏈灏�
        $('[data-field=text]').on('keyup', function() {
            var fieldTextCount = $(this).val();
            $('[data-field=count]').html(fieldTextCount.length);
        });
        //琛ㄥ崟鍙戦€侀獙璇佺爜瀹氭椂鍣�
        $('[data-yzm=send]').on(ick, function() {
            $('[data-yzm=send]').attr('disabled', 'disabled');
            $('[data-yzm=send]').css({ 'color': '#ddd' });
            $('[data-yzm=send]').val('閲嶆柊鍙戦€�(59s)');
            var secondFS = 60;
            var secondITV = setInterval(function() {
                secondFS--;
                $('[data-yzm=send]').val('閲嶆柊鍙戦€�(' + secondFS + ')');
            }, 1000);
            setTimeout(function() {
                $('[data-yzm=send]').removeAttr('disabled');
                $('[data-yzm=send]').css({ 'color': '#333' });
                $('[data-yzm=send]').val('閲嶆柊鍙戦€�');
                clearInterval(secondITV);
            }, 60000);
        });
        //涓嬫媺妗哾ropDownBox
        var ddbBox = 0;
        $('[data-box=toggle]').on(ick, function() {
            if (ddbBox == 0) {
                $(this).children('span').css('-webkit-transform', 'rotate(0deg)');
                ddbBox = 1;
            } else {
                $(this).children('span').css('-webkit-transform', 'rotate(180deg)');
                ddbBox = 0;
            }
            $(this).siblings('div').stop().slideToggle();

        });
        //涓嬫媺妗哾ropDownEasy 
        var easy = 0;
        $('[data-easy=toggle]').on(ick, function() {
            if (easy == 0) {
                $(this).children('span').css('-webkit-transform', 'rotate(0deg)');
                easy = 1;
            } else {
                $(this).children('span').css('-webkit-transform', 'rotate(180deg)');
                easy = 0;
            }
            $(this).siblings('div').stop().slideToggle();

        });
        //涓嬫媺妗哾ropDownMenu
        var menu = 0;
        $('[data-menu=toggle]').on(ick, function() {
            if (menu == 0) {
                $(this).children('span').css('-webkit-transform', 'rotate(0deg)');
                menu = 1;
            } else {
                $(this).children('span').css('-webkit-transform', 'rotate(180deg)');
                menu = 0;
            }
            $(this).siblings('div').stop().slideToggle();

        });
        //涓嬫媺鑿滃崟menu
        $('[data-ddb=menu] ul li').on(ick, function() {
            $(this).parent().parent().slideUp();
            $(this).parent().parent().siblings('h6').children('span').css('-webkit-transform', 'rotate(0deg)');
            $(this).parent().parent().siblings('h6').children('b').html($(this).html());
        });
    },
    graphicContent: function() {
        //鑷姩鎴彇瀛楃涓插苟涓斾繚鐣欎繚鐣欏瓧3琛�
        if ($('[data-adaptive=adp]').width() != null) {
            $('[data-adaptive=adp]').width($('[data-adaptive=adp]').width());
            var str = $('[data-adaptive=adp]').html();
            var strs = str.substr(0, parseInt($('[data-adaptive=adp]').width() / 6));
            $('[data-adaptive=adp]').html(str.substr(0, parseInt($('[data-adaptive=adp]').width() / 6) - 5));
            $('[data-adaptive=adp]').append('...<span class="ft-usual">鏌ョ湅鏇村</span>');
            //4琛岀殑
            $('[data-adaptive=adp4]').width($('[data-adaptive=adp4]').width());
            var str = $('[data-adaptive=adp4]').html();
            var strs = str.substr(0, parseInt($('[data-adaptive=adp4]').width() / 6));
            $('[data-adaptive=adp4]').html(str.substr(0, parseInt($('[data-adaptive=adp4]').width() / 6) - 7));
            $('[data-adaptive=adp4]').append('...<span class="ft-usual">鏌ョ湅鏇村</span>');
        };
    },
    //寮瑰嚭妗�
    dialog: {
        blackLog: function() {
            //榛戣壊妗�   cont鎻愮ず妗嗘枃鏈彁绀哄唴瀹�    pixel璺濈椤堕儴澶氬皯闂磋窛   times鏄剧ず鐨勬椂闂村懆鏈�
            this.showMessage = function(cont, pixel, times) {
                var times, pixel;
                if (!arguments[2]) {
                    times = 2000;
                }
                if (!arguments[1]) {
                    pixel = 100;
                }
                $('body').append('<section id="showMessage" style="display:none;position: fixed;z-index: 99;top:' + pixel + 'px;left: 50%;background: rgba( 0 , 0 , 0 ,.8);color: #fff;margin: -15px 0 0 -100px;width: 200px;height: 30px;line-height: 30px;border-radius: 5px;text-align: center;">' + cont + '</section>');
                $('#showMessage').fadeIn(300, function() {
                    $('#showMessage').fadeOut(times);
                });
                setTimeout(function() {
                    $('#showMessage').remove();
                }, times);

            }


        }

    }
};


//璀︾ず淇℃伅
var log = {
    time: function() {
        var thisTime = new Date();
        return thisTime.toLocaleTimeString() + ' ';
    },
    error: function(message) {
        document.write('<br><span style="color:red";>' + this.time() + '-DEBUG </span>' + message + '<br>');
        return false;
    },
    Debug: function(message) {
        document.write('<br><span style="color:blue";>' + this.time() + '-DEBUG </span>' + message + '<br>');
    }
};




//琛ㄧ幇灞傦紙Presentation layer锛�
//鍩烘湰璁剧疆
Mxywy.basic();
//璋冪敤棣栧熬
var parameter = new Mxywy.pate();
//琛ㄥ崟鍩烘湰璁剧疆
Mxywy.webForms();
//寮瑰嚭妗�
var blackMessage = new Mxywy.dialog.blackLog();
//璋冪敤鍥炬枃
Mxywy.graphicContent();

















