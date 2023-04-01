$(document).ready(function () {

    function showCardsAndAverage() {
        $.ajax({
            url: "/Game/ShowCards",
            type: "GET",
            success: function(scores) {
                $("#averageValue").text(scores.averageScore);                
                $("#myCard").text(scores.myCardValue);
                $(".player").removeClass("cardValueHidden");

                $(".showButton").addClass("newVoteButton");
                $(".showButton").text("New Vote");
                $(".showButton").removeClass("showButton");
            },
            error: function(error) {
                Console.log("Error: " + error);
            }
        })
    }

    function newVote() {
        $("#averageValue").text("");                
        $(".player").addClass("cardValueHidden");
        $(".voting").removeClass("selected");

        $(".newVoteButton").addClass("showButton");
        $(".showButton").text("Show");
        $(".newVoteButton").removeClass("newVoteButton");
    }

    $(".results").on("click", ".showButton", showCardsAndAverage);
    $(".results").on("click", ".newVoteButton", newVote);

});
