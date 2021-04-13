$(function () {
    console.log("Page is ready");

    $(document).on("click", ".game-button", function (event) {
        event.preventDefault();

        //var coordArray = Array.from($(this).val());
        var buttonNumber
        console.log("Game button # " + buttNum + " was clicked");
        doButtonUpdate(buttonNumber);
    })

    $(document).on("click", "start-game", function (event) {
        event.preventDefault();

        var size = $(this).val();
        doGameStart(size);
    })
});

function doButtonUpdate(buttonNumber) {
    $.ajax({
        datatype: "json",
        method: 'POST',
        url: '/minesweeper/Click',
        data: {
            "buttonNumber": buttonNumber
        },
        success: function (data) {
            console.log(data);
            $("#" + buttNum).html(data);
        }
    });
}

function doGameStart(size) {
    $.ajax({
        datatype: "json",
        method: 'POST',
        url: '/minesweeper/',
        dara: {
            "size": size
        },
        success: function (data) {
            $(".game-board").html(data);
        }
    });
}