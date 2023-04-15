var connection = new signalR.HubConnectionBuilder()
    .withUrl("/scrumPokerHub")
    .build();

async function start() {
    try {
        await connection.start();
        console.log("SignalR Hub Connected");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    await start();
});




// connection.on("AddWord", function(message) {
//     $("#averageValue").append(message);
// });
//
// $("#testButton").click(function() {
//     var averageValue = $("#averageValue").text().toString();
//     console.log(averageValue);
//     connection.invoke("TestButton", averageValue)
//         .catch(function(err) {
//             return console.error(err.toString());
//         })
// })

start();