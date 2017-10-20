$(document).ready(function () {
    // the "href" attribute of the modal trigger must specify the modal ID that wants to be triggered
    $('.modal').modal();
    $('.tap-target').tapTarget('open');
    
    
    $(body).on("click", function(){
        $('.tap-target').tapTarget('close');
    })

});

function reset() {
    document.getElementById("noteTitle").value = ""; // Create text with HTML
    document.getElementById("noteContent").value = "";
}


function newNote() {
    var title = document.getElementById("noteTitle").value; // Create text with HTML
    var content = document.getElementById("noteContent").value;
    $(".container").append(" <div class='card blue-grey darken-1'><div class='card-content white-text'><span class='card-title'>" + title + "</span><p>" + content + "</p></div><div class='card-action'><a href='#' onclick='dismissNote();'>dismiss</a></div></div>");
    Materialize.toast('Added successfully!', 1000);
}

function dismissNote() {
    Materialize.toast('Dismiss successfully!', 1000);
    $('.card-action').on('click', function () {
        $(this).parent('div.card').remove();

    });
}

function underDev() {
    Materialize.toast('Under development', 1000);
}

function dismissDiscovery(){
    $('.tap-target').tapTarget('close');
}