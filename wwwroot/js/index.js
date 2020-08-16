$(document).ready(function () {
    var x = 0;
    var s = "";

    console.log("Hello Pluralsight");

    var theForm = $("#theForm");
    //var theForm = document.getElementById("theForm");
    theForm.hide();
    //theForm.hidden = true;

    var button = $("buyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });

    //var productInfo = document.getElementById("product-props");
    var productInfo = $(".product-props li"); // .product-props li is in css
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });
});