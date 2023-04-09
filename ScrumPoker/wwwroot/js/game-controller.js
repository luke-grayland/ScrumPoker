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
        $("#myCard").text("");
        $(".player").addClass("cardValueHidden");
        $(".voting").removeClass("selected");
        
        $(".newVoteButton").addClass("showButton");
        $(".showButton").text("Show");
        $(".newVoteButton").removeClass("newVoteButton");
    }

    function newGame() {
        window.location.href = "/Home/Index";
    };

    function showHideInviteWindow() {
        if ($("#inviteButton").hasClass("inviteVisible"))
        {
            $(".inviteWindow").fadeOut();
            $("#inviteButton").removeClass("inviteVisible");
        } 
        else if ($("#inviteButton").hasClass("inviteHidden")) {
            $(".inviteWindow").fadeIn();
            $("#inviteButton").addClass("inviteVisible");
        } 
      }

      function clickAnywhereHideWindow(e) {
        if(!$(e.target).hasClass("inviteWindow") 
        && !$(e.target).is("#inviteWindow"))
        {
            $(".inviteWindow").fadeOut();
            $("#inviteButton").removeClass("inviteVisible");

            //make hideWindow function above lines repeated

        }
      }

    $(".results").on("click", ".showButton", showCardsAndAverage);
    $(".results").on("click", ".newVoteButton", newVote);
    $("#newGame").click(newGame);
    $("#inviteButton").click(showHideInviteWindow);
    $("html").click(clickAnywhereHideWindow);
    
});
