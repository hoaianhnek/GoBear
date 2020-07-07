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
                html += "<div class='col-3'><div class='name-product'><div class='content-listproduct'><img src='../images/" + element.b.image_Bank + "'>";
                html += "<div><h5>" + element.b.name_Bank + "</h5><h6>" + element.i.tenBH + "</h6></div> <div class='price'>";
                html += "<span>"+element.i.price+"đ</span><span>/Chuyến</span></div><a href='%'>Đăng Ký Ngay</a><a href='#'>x</a>";
                html += "</div></div></div>";
            });
            $("#content-listproduct").prepend(html);
            //so sánh các đặc điểm sản phẩm
            html = ""; 
            data.forEach(e=> {
                html += '<div class="col-3"><div><span>'+e.i.rate+'<span>/10</span></span>';
                html += '<span>Đánh giá chung</span></div></div>';
            });
            $("#product-hot .products-info> div.row").prepend(html);
            //thông tin chung
            html ="";
            data.forEach(e=> {
                if(e.i.buyonline == "yes") {
                    html += '<div class="col-3"><div><i class="fas fa-check"></i></div> </div>';
                }
                else {
                    html += '<div class="col-3"><div>-</div> </div>'
                }
            });
            $('.payonline .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.i.regula_age != "") {
                    html += '<div class="col-3"><div><span>'+e.i.regula_age+'</span></div></div>';
                } 
                else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });

            $('.regula-age .products-info> div.row').prepend(html);

            
            html = "";
            data.forEach(e=> {
                if(e.i.define_family != "") {
                    html += '<div class="col-3"><div><span>'+e.i.define_family+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.define-family .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.i.repatriation != "") {
                    html += '<div class="col-3"><div><span>'+e.i.repatriation+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.children .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if (e.i.hightlight != "") {
                    html += '<div class="col-3"><div><span>'+e.i.hightlight+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.hightlight .products-info> div.row').prepend(html);

            html = "";
            data.forEach(e=> {
                if(e.i.accident_myself != "") {
                    html += '<div class="col-3"><div><span>'+e.i.accident_myself+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.accident_myself .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e=> {
                if(e.i.foreign_medical != "") {
                    html += '<div class="col-3"><div><span>'+e.i.foreign_medical+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.foreign_medical .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e=> {
                if(e.i.patients_relative != "") {
                    html += '<div class="col-3"><div><span>'+e.i.patients_relative+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.patients_relative .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e=> {
                if(e.i.subsidize != "") {
                    html += '<div class="col-3"><div><span>'+e.i.subsidize+'</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.subsidize .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.medical_transport != "") {
                    html += '<div class="col-3"><div><span>' + e.i.medical_transport + '</span></div></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.medical_transport .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.support_service == "yes") {
                    html += '<div class="col-3"><div><i class="fas fa-check"></i></div> </div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.support_service .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.repatriated_corpse != "") {
                    html += '<div class="col-3"><div><span>' + e.i.repatriated_corpse+'</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.repatriated_corpse .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.responsibility_third != "") {
                    html += '<div class="col-3"><div><span>' + e.i.responsibility_third + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.responsibility_third .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.lost_travel != "") {
                    html += '<div class="col-3"><div><span>' + e.i.lost_travel + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.lost_travel .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.receiving_slowly != "") {
                    html += '<div class="col-3"><div><span>' + e.i.receiving_slowly + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.receiving_slowly .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.damages != "") {
                    html += '<div class="col-3"><div><span>' + e.i.damages + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.damages .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.trip_delay != "") {
                    html += '<div class="col-3"><div><span>' + e.i.trip_delay + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.trip_delay .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.cancel_trip != "") {
                    html += '<div class="col-3"><div><span>' + e.i.cancel_trip + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.cancel_trip .products-info> div.row').prepend(html);
            html = "";
            data.forEach(e => {
                if (e.i.giveup_trip != "") {
                    html += '<div class="col-3"><div><span>' + e.i.giveup_trip + '</span></div>';
                } else {
                    html += '<div class="col-3"><div>-</div></div>';
                }
            });
            $('.giveup_trip .products-info> div.row').prepend(html);
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
        $('.content-listproduct> img').css({'display':'inline-block'});
    }
});