$(document).ready(function () {

    $(".voting").click(function () {
        $(".voting").removeClass("selected");
        $(this).addClass("selected");

        //try using e.target instead
        var selectedCardValue = parseInt($(this).find("h3").text());
        
        $.ajax({
            url: "/Player/UpdatePlayerVote",
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

