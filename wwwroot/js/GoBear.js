$(document).ready(function () {
    $.ajax({
        type: 'GET',
        url: '/Home/LoadData/',
        data: "{}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            var html = "";
            console.log(data);
            data.forEach(element => {
                html += "<div class='col-3'><div class='name-product'><div class='content-listproduct'><img src='../images/f4b545f8-2a3c-4b1d-b36f-4e7f1c705538.png'>";
                html += "<div><h5>BIC</h5><h6>"+element.tenBH+"</h6></div> <div class='price'>";
                html += "<span>"+element.price+"đ</span><span>/Chuyến</span></div><a href='%'>Đăng Ký Ngay</a><a href='#'>x</a>";
                html += "</div></div></div>";
            });
            $("#content-listproduct").prepend(html);
            html = ""; 
            data.forEach(e=> {
                html += '<div class="col-3"><div><span>'+e.rate+'<span>/10</span></span>';
                html += '<span>Đánh giá chung</span></div></div>';
            });
           
            $("#product-hot .products-info> div.row").prepend(html);
            html ="";
            data.forEach(e=> {
                if(e.buyonline == "yes") {
                    html += '<div class="col-3"><div><i class="far fa-check"></i></div> </div>';
                }
                else {
                    html += '<div class="col-3"><div>-</div> </div>'
                }
            });
            $('.payonline .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.regula_age != "") {
                    html += '<div class="col-3"><div><span>'+e.regula_age+' tuổi</span></div></div>';
                } 
                else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });

            $('.regula-age .products-info> div.row').prepend(html);

            
            html = "";
            data.forEach(e=> {
                if(e.define_family != "") {
                    html += '<div class="col-3"><div><span>'+e.define_family+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.define-family .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.repatriation != "") {
                    html += '<div class="col-3"><div><span>'+e.repatriation+'đ</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.children .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.repatriation != "") {
                    html += '<div class="col-3"><div><span>'+e.hightlight+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.hightlight .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.accident_myself != "") {
                    html += '<div class="col-3"><div><span>'+e.accident_myself+'đ</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.accident_myself .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e=> {
                if(e.foreign_medical != "") {
                    html += '<div class="col-3"><div><span>'+e.foreign_medical+'đ</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.foreign_medical .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e=> {
                if(e.patients_relative != "") {
                    html += '<div class="col-3"><div><span>'+e.patients_relative+'đ</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.patients_relative .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e=> {
                if(e.subsidize != "") {
                    html += '<div class="col-3"><div><span>'+e.subsidize+'đ</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.subsidize .products-info> div.row').prepend(html);
        }
    });
    
});
$(document).scroll(function() {
    var y = $(this).scrollTop();
    if(y>=100) {
        $('header').css({"box-shadow":"0px -4px 6px 2px #0000007d"});
        $('.content-product-wrap').css({'position':'fixed',"box-shadow":"0px -4px 6px 2px #0000007d"});
        $('.content-listproduct> img').css({'display':'none'});
    } else {
        $('header').css({"box-shadow":"none"});
        $('.content-product-wrap').css({'position':'static',"box-shadow":"none"});
        $('.content-listproduct> img').css({'display':'block'});
    }
});