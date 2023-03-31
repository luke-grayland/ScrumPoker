$(document).ready(function () {

    $(".voting").click(function () {
        $(".voting").removeClass("selected");
        $(this).addClass("selected");

        //try using e.target instead
        var selectedCardValue = ($(this).find("h3").text().parseInt());

        $.ajax({
            url: "/Card/UpdateCard",
            type: "POST",
            data: { cardValue: selectedCardValue },
            success: function() {
                "Success";
            },
            error: function() {
                "Error";
            }
        });
    });



});




//$(document).ready({

//    $(".voting").click(function() {
//        $(".voting").removeClass("selected");
//        $(this).addClass("selected");
    
//        //try using e.target instead
//        var selectedCardValue = ($(this).find("h3").text().parseInt());
    
//        //$.ajax({
//        //    url: "/Controller/Method",
//        //    type: "POST",
//        //    data: { cardValue: selectedCardValue },
//        //    success: function() {
//        //        "Success";
//        //    },
//        //    error: function() {
//        //        "Error";
//        //    }
//        //});
//    });
    
//    $("#newGame").click(function() {
//        $ajax({
//            url: 'Home/Index',
//            type: 'GET',
//            success: function() {
//                "Success"
//            },
//            error: function() {
//                "Error"
//            }
//        })
//    })

//});

