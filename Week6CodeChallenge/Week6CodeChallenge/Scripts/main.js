$(document).ready(function () {

    $('body').on('click', '.ajax-get', function (event) {

        //bind this click event 
        //extract the name of the url we clicked on
        var url = $(this).attr('href');
        //disable default behaivior 
        event.preventDefault();
        //i want to make an ajax request
        $.get(url, function (data) {
            $('#ajax-content').html(data);
        });

    });


    //bind a click event to our tab buttons
    $('body').on('click', '.tabs button', function () {
        var tabid = $(this).data('tabid');
        //hide all of the tabs
        $('.tabs .panel').addClass('hide');
        //show the tab panel we clicked on
        $('#tab' + tabid).removeClass('hide');
        //remove the active class from all of the buttons
        $('.tabs button').removeClass('active');
        //add the active class to the button we clicked on
        $(this).addClass('active');
    });

    $(body).on('submit', '.ajax-post', function (event) {
        event.preventDefault();
        var url = $(this).attr('action');
        $.post(url, $(this).serialize(), function (data) {
            $('#ajax-content').html("Thank You" + data)

        })
    });



});