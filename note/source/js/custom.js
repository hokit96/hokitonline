$(document).ready(function () {
    // the "href" attribute of the modal trigger must specify the modal ID that wants to be triggered
    $('.modal').modal();
    $('.tap-target').tapTarget('open');
    $(body).on("click", function(){
        $('.tap-target').tapTarget('close');
    })
});







function underDev() {
    Materialize.toast('Under development', 1000);
}

function dismissDiscovery(){
    $('.tap-target').tapTarget('close');
}