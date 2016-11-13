$(function () {
    var amounts = $(".sum");
    $.each(amounts, function (index, value)
    {
        if (value.innerText < 0)
        {
            $(this).addClass("data-monetary-amount")
        }
    })
  
});