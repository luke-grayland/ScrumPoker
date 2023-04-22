const connection = new signalR.HubConnectionBuilder()
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

connection.on("ReceiveGameModelUpdate", function(gameModel) {
   console.log(gameModel);
   connection.invoke("UpdateLocalGameModel", gameModel); 
});

start();