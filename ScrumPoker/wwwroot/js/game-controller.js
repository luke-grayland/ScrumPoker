$(document).ready(function () {

    $(".showButton").click(function () {
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
            error: function() {
                "Error";
            }
        })
    });

    $(".newVoteButton".click(function() {
        

        $(".newVoteButton").addClass("showButton");
        $(".showButton").text("Show");
        $(".newVoteButton").removeClass("newVoteButton");

        // $.ajax({
        //     url: "/Game/NewVote",
        //     type: "GET",
        //     success: function() {
        //         //reset scores  (might not need to do anything on backend)

        //         $(".newVoteButton").addClass("showButton");
        //         $(".showButton").text("Show");
        //         $(".newVoteButton").removeClass("newVoteButton");
        //     },
        //     error: function() {
        //         "Error";
        //     }
        // })

    }));

});
